using ClinicBusiness.Models;
using ClinicBusiness.Services;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    // ============================================================================
    // ملاحظات مهمة قبل الاستخدام:
    //
    // 1) clsClinicSettings هي خدمة أعمال مفترضة (بنفس نمط clsInvoice / clsPayment
    //    المستخدمة في باقي المشروع). لازم تكون عندك دالتين:
    //       - Task<ClinicSettingsDTO?> GetSettingsAsync()
    //       - Task SaveSettingsAsync(ClinicSettingsDTO dto)
    //    لو الأسماء مختلفة عندك، عدّل استدعاءاتها في LoadSettingsAsync() و SaveSettingsToDatabaseAsync().
    //
    // 2) ClinicSettingsDTO في آخر الملف كلاس مساعد مؤقت. لو عندك DTO حقيقي بنفس
    //    الخصائص في ClinicBusiness.DTO، احذف الكلاس ده واستخدم بتاعك.
    //
    // 3) أوقات الدوام بتتخزن كـ TimeSpan (WorkStart / WorkEnd) مش DateTime كامل،
    //    والشعار بيتخزن كـ byte[] (LogoBytes) جاهز للحفظ في عمود varbinary/image.
    // ============================================================================

    public partial class frmClinicSettings : Form
    {
        private readonly ClinicManagementSystemContext _context;
        private readonly clsClinicSettings _settingsService;

        // الصورة الحالية بصيغة Bytes، جاهزة للحفظ المباشر في قاعدة البيانات
        private byte[]? _logoBytes;

        // لمنع محاولات الحفظ المتكررة أثناء عملية حفظ جارية بالفعل
        private bool _isSaving;

        public frmClinicSettings()
        {
            InitializeComponent();

            _context = new ClinicManagementSystemContext();
            _settingsService = new clsClinicSettings(_context);

            WireUpEvents();
        }

        // ─────────────────────────────────────────────────────────────
        // ربط الأحداث
        // ─────────────────────────────────────────────────────────────
        private void WireUpEvents()
        {
            Load += frmClinicSettings_Load;
            FormClosed += frmClinicSettings_FormClosed;

            tabControl.DrawItem += tabControl_DrawItem;

            btnUploadLogo.Click += btnUploadLogo_Click;
            btnRemoveLogo.Click += btnRemoveLogo_Click;

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;

            // قبول أرقام فقط لحقل الرقم الضريبي (اختياري - شيله لو رقم العيادة الضريبي فيه حروف/رموز)
            txtTaxNumber.KeyPress += NumericOnly_KeyPress;
        }

        // ─────────────────────────────────────────────────────────────
        // رسم مسطح حديث للتبويبات (Flat Style) بدل الشكل الافتراضي للـ TabControl
        // ─────────────────────────────────────────────────────────────
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabRect = tabControl.GetTabRect(e.Index);
            bool isSelected = e.Index == tabControl.SelectedIndex;

            Color backColor = isSelected
                ? Color.FromArgb(23, 162, 148)   // نفس لون زر الحفظ (Teal) للتبويب النشط
                : Color.FromArgb(233, 236, 239); // رمادي فاتح للتبويبات غير النشطة

            Color textColor = isSelected
                ? Color.White
                : Color.FromArgb(73, 80, 87);

            using (var backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, tabRect);
            }

            TextRenderer.DrawText(
                e.Graphics,
                tabControl.TabPages[e.Index].Text,
                tabControl.Font,
                tabRect,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // ─────────────────────────────────────────────────────────────
        // تحميل الفورم وجلب الإعدادات الحالية من قاعدة البيانات
        // ─────────────────────────────────────────────────────────────
        private async void frmClinicSettings_Load(object sender, EventArgs e)
        {
            await LoadSettingsAsync();
        }

        private async Task LoadSettingsAsync()
        {
            try
            {
                ClinicSettings settings = await _settingsService.GetSettingsAsync();

                if (settings == null)
                {

                    ApplyDefaultSettings();
                    return;
                }

                // ── البيانات العامة ──
                txtClinicNameAr.Text = settings.ClinicName;
                txtClinicNameEn.Text = settings.ClinicNameEn;
                txtTaxNumber.Text = settings.TaxNumber;
                txtAddress.Text = settings.Address;

                _logoBytes = settings.Logo;
                ApplyLogoBytesToPictureBox(_logoBytes);

                // ── بيانات الاتصال ──
                txtPhone1.Text = settings.PhoneNumber1;
                txtPhone2.Text = settings.PhoneNumber2;
                txtEmail.Text = settings.Email;
                txtWebsite.Text = settings.Website;

                // ── جدولة المواعيد ──
                numAppointmentDuration.Value = Math.Max(
                    numAppointmentDuration.Minimum,
                    Math.Min(numAppointmentDuration.Maximum, settings.AppointmentDurationMinutes));

                dtpWorkStart.Value = DateTime.Today.Add(settings.ClinicStartTime);
                dtpWorkEnd.Value = DateTime.Today.Add(settings.ClinicEndTime);

                // 🛠️ الإصلاح هنا: تحويل النص المفصول بفاصلة إلى مصفوفة أيام للمقارنة الصحيحة
                string[] holidays = !string.IsNullOrWhiteSpace(settings.WeekendDays)
                    ? settings.WeekendDays.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    : Array.Empty<string>();

                for (int i = 0; i < clbWeeklyHolidays.Items.Count; i++)
                {
                    string dayName = clbWeeklyHolidays.Items[i]?.ToString()?.Trim() ?? string.Empty;

                    // نتحقق من وجود اسم اليوم داخل المصفوفة بدقة (مع تجاهل حالة الأحرف لو كانت بالإنجليزية)
                    bool isHoliday = Array.Exists(holidays, d => d.Trim().Equals(dayName, StringComparison.OrdinalIgnoreCase));

                    clbWeeklyHolidays.SetItemChecked(i, isHoliday);
                }

                // ── الإعدادات المالية ──
                if (!string.IsNullOrWhiteSpace(settings.DefaultCurrency) &&
                    cmbDefaultCurrency.Items.Contains(settings.DefaultCurrency))
                {
                    cmbDefaultCurrency.SelectedItem = settings.DefaultCurrency;
                }
                else if (cmbDefaultCurrency.Items.Count > 0)
                {
                    cmbDefaultCurrency.SelectedIndex = 0;
                }

                numTaxPercentage.Value = Math.Max(
                    numTaxPercentage.Minimum,
                    Math.Min(numTaxPercentage.Maximum, settings.TaxRate));

                txtInvoiceNotes.Text = settings.DefaultInvoiceNotes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل إعدادات العيادة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ApplyDefaultSettings();
            }
        }

        private void ApplyDefaultSettings()
        {
            numAppointmentDuration.Value = 30;
            dtpWorkStart.Value = DateTime.Today.AddHours(9);
            dtpWorkEnd.Value = DateTime.Today.AddHours(17);

            if (cmbDefaultCurrency.Items.Count > 0)
                cmbDefaultCurrency.SelectedIndex = 0;

            numTaxPercentage.Value = 0;
            _logoBytes = null;
            ApplyLogoBytesToPictureBox(null);
        }

        // ─────────────────────────────────────────────────────────────
        // رفع/حذف شعار العيادة (تحويل الصورة إلى byte[] وبالعكس)
        // ─────────────────────────────────────────────────────────────
        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            if (ofdLogo.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                byte[] fileBytes = File.ReadAllBytes(ofdLogo.FileName);

                // نتأكد إن الملف فعلاً صورة صالحة قبل اعتمادها
                using (var ms = new MemoryStream(fileBytes))
                using (var testImage = Image.FromStream(ms))
                {
                    _logoBytes = fileBytes;
                }

                ApplyLogoBytesToPictureBox(_logoBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"تعذر تحميل الصورة المحددة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveLogo_Click(object sender, EventArgs e)
        {
            _logoBytes = null;
            ApplyLogoBytesToPictureBox(null);
        }

        private void ApplyLogoBytesToPictureBox(byte[]? logoBytes)
        {
            picLogo.Image?.Dispose();

            if (logoBytes == null || logoBytes.Length == 0)
            {
                picLogo.Image = null;
                return;
            }

            using var ms = new MemoryStream(logoBytes);
            // ننسخ الصورة في ذاكرة مستقلة عشان الـ MemoryStream ميتقفلش وهي لسه مستخدمة
            picLogo.Image = new Bitmap(Image.FromStream(ms));
        }

        // ─────────────────────────────────────────────────────────────
        // السماح بالأرقام فقط (اختياري لحقل الرقم الضريبي)
        // ─────────────────────────────────────────────────────────────
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }

        // ─────────────────────────────────────────────────────────────
        // حفظ التغييرات
        // ─────────────────────────────────────────────────────────────
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_isSaving)
                return;

            if (!ValidateSettingsForm())
                return;

            try
            {
                _isSaving = true;
                btnSave.Enabled = false;

                var dto = BuildSettingsDtoFromForm();

                // 🛠️ الإصلاح هنا: استقبال النتيجة وفحصها
                bool isSuccess = await _settingsService.UpdateClinicSettingsAsync(dto);

                if (isSuccess)
                {
                    MessageBox.Show("تم حفظ إعدادات العيادة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("تعذر حفظ الإعدادات، يرجى التحقق من البيانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ الإعدادات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isSaving = false;
                btnSave.Enabled = true;
            }
        }
        private bool ValidateSettingsForm()
        {
            if (string.IsNullOrWhiteSpace(txtClinicNameAr.Text))
            {
                MessageBox.Show("اسم العيادة بالعربية حقل إجباري.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabGeneral;
                txtClinicNameAr.Focus();
                return false;
            }

            if (dtpWorkEnd.Value.TimeOfDay <= dtpWorkStart.Value.TimeOfDay)
            {
                MessageBox.Show("وقت انتهاء الدوام يجب أن يكون بعد وقت البدء.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabScheduling;
                dtpWorkEnd.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("صيغة البريد الإلكتروني غير صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabContact;
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private ClinicSettings BuildSettingsDtoFromForm()
        {
            var checkedHolidays = clbWeeklyHolidays.CheckedItems
                               .Cast<object>()
                               .Select(item => item.ToString() ?? string.Empty)
                               .Where(name => !string.IsNullOrEmpty(name))
                               .ToList();



            return new ClinicSettings
            {
                ClinicName = txtClinicNameAr.Text.Trim(),
                ClinicNameEn = txtClinicNameEn.Text.Trim(),
                TaxNumber = txtTaxNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Logo = _logoBytes,

                PhoneNumber1 = txtPhone1.Text.Trim(),
                PhoneNumber2 = txtPhone2.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Website = txtWebsite.Text.Trim(),

                AppointmentDurationMinutes = (int)numAppointmentDuration.Value,


                ClinicStartTime = dtpWorkStart.Value.TimeOfDay,
                ClinicEndTime = dtpWorkEnd.Value.TimeOfDay,

                WeekendDays = string.Join(",", checkedHolidays),

                DefaultCurrency = cmbDefaultCurrency.SelectedItem?.ToString() ?? string.Empty,
                TaxRate = numTaxPercentage.Value,
                DefaultInvoiceNotes = txtInvoiceNotes.Text.Trim(),
                UpdatedAt = DateTime.Now

            };
        }

        // ─────────────────────────────────────────────────────────────
        // إلغاء الأمر — إعادة تحميل القيم الأصلية بعد تأكيد المستخدم
        // ─────────────────────────────────────────────────────────────
        private async void btnCancel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "سيتم تجاهل أي تغييرات غير محفوظة. هل تريد المتابعة؟",
                "تأكيد الإلغاء",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            await LoadSettingsAsync();
        }

        // ─────────────────────────────────────────────────────────────
        // تنظيف الموارد عند إغلاق الفورم
        // ─────────────────────────────────────────────────────────────
        private void frmClinicSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            picLogo.Image?.Dispose();
            _context?.Dispose();
        }

        private void btnRemoveLogo_Click_1(object sender, EventArgs e)
        {
            if (_logoBytes == null || _logoBytes.Length == 0)
            {
                MessageBox.Show("لا يوجد شعار حالي لحذفه!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. تأكيد رغبة المستخدم في الحذف لتجنب الأخطاء العفوية
            DialogResult result = MessageBox.Show("هل أنت متأكد من رغبتك في حذف شعار العيادة؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                // 3. تصفير متغير الـ Bytes برمجياً
                _logoBytes = null;

                // 4. تحديث الـ PictureBox لعرض صورة فارغة أو افتراضية
                if (picLogo.Image != null)
                {
                    picLogo.Image.Dispose(); // تحرير الذاكرة من الصورة القديمة فوراً
                    picLogo.Image = null;    // إزالة الصورة من الأداة
                }

                // اختياري: إذا كان لديك ميثود مخصصة لإعادة الصورة الافتراضية للعيادة يمكنك استدعاؤها هنا:
                ApplyLogoBytesToPictureBox(null);

                MessageBox.Show("تم إزالة الشعار بنجاح. يرجى الضغط على حفظ لتأكيد التغييرات في النظام.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إزالة الصورة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdvancedSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form frm = new frmAdvancedSettings())
            {
                frm.ShowDialog();
            }
        }
    }

    // ============================================================================
    // DTO مساعد مؤقت لبيانات إعدادات العيادة.
    // لو عندك DTO حقيقي بنفس الخصائص في ClinicBusiness.DTO، احذف الكلاس ده واستخدم بتاعك.
    // ============================================================================

}