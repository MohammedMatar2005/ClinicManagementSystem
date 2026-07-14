

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicBusiness.DTO.UsersDTOs;

namespace ClinicManagementSystem // تأكد من مطابقة اسم الـ Namespace لمشروعك
{
    public partial class frmSystemLogs : Form
    {
        private readonly UserViewDTO _currentUser;
        private readonly clsLoggingService _loggingService;
        private List<SystemLog> _allLogs = new List<SystemLog>();

        public frmSystemLogs(UserViewDTO currentUser, clsLoggingService loggingService)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _loggingService = loggingService;

            // إعدادات البداية
            SetupSeverityComboBox();
        }

        private async void frmSystemLogs_Load(object sender, EventArgs e)
        {
            await LoadLogsAsync();
        }

        // 1. جلب البيانات من السيرفيس وعرضها
        private async Task LoadLogsAsync()
        {
            try
            {
                btnRefresh.Enabled = false;

                // جلب السجلات من قاعدة البيانات
                _allLogs = await _loggingService.GetAllLogsAsync();

                // تطبيق الفلترة والعرض
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل السجلات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }

        // 2. تعبئة قائمة درجات الخطورة (ComboBox)
        private void SetupSeverityComboBox()
        {
            var severityItems = new List<object>
            {
                new { Text = "الكل", Value = (byte)0 },
                new { Text = "معلومات (Information)", Value = (byte)enLogSeverity.Information },
                new { Text = "تحذير (Warning)", Value = (byte)enLogSeverity.Warning },
                new { Text = "خطأ (Error)", Value = (byte)enLogSeverity.Error },
                new { Text = "حرج (Critical)", Value = (byte)enLogSeverity.Critical }
            };

            cmbSeverity.DisplayMember = "Text";
            cmbSeverity.ValueMember = "Value";
            cmbSeverity.DataSource = severityItems;
            cmbSeverity.SelectedIndex = 0; // افتراضياً يعرض الكل
        }

        // 3. فلترة البيانات محلياً بدون تكرار طلب قاعدة البيانات لسرعة الأداء
        private void ApplyFilters()
        {
            if (_allLogs == null) return;

            var filtered = _allLogs.AsEnumerable();

            // الفلترة حسب درجة الخطورة
            if (cmbSeverity.SelectedValue is byte severityValue && severityValue > 0)
            {
                filtered = filtered.Where(l => l.SeverityLevel == severityValue);
            }

            // الفلترة حسب نص البحث
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                filtered = filtered.Where(l => l.EventName.Contains(searchText, StringComparison.OrdinalIgnoreCase));
            }

            // إسقاط البيانات في كائن مخصص مفرود (Flattened) للـ GridView
            var displayList = filtered.Select(l => new
            {
                الرقم = l.LogID,
                الحدث = l.EventName,
                درجة_الخطورة = GetSeverityArabicText((enLogSeverity)l.SeverityLevel),
                التوقيت = l.LogTimestamp.ToString("yyyy-MM-dd HH:mm:ss"),
                بواسطة = l.CreatorUser?.Username ?? "النظام تلقائي"
            }).ToList();

            dgvLogs.DataSource = displayList;

            // تنسيق أحجام الأعمدة برمجياً لملء الشاشة بالكامل
            if (dgvLogs.Columns.Count > 0)
            {
                dgvLogs.Columns["الرقم"].Width = 80;
                dgvLogs.Columns["الحدث"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvLogs.Columns["درجة_الخطورة"].Width = 150;
                dgvLogs.Columns["التوقيت"].Width = 180;
                dgvLogs.Columns["بواسطة"].Width = 150;
            }

            lblTotalCount.Text = $"إجمالي السجلات الحالية: {displayList.Count} سجل";
        }

        // تحويل الـ Severity إلى نص عربي منسق
        private string GetSeverityArabicText(enLogSeverity severity)
        {
            return severity switch
            {
                enLogSeverity.Information => "ℹ️ معلومات",
                enLogSeverity.Warning => "⚠️ تحذير",
                enLogSeverity.Error => "❌ خطأ",
                enLogSeverity.Critical => "🔥 حرج جداً",
                _ => "غير معروف"
            };
        }

        // 4. الأحداث (Events) الخاصة بعناصر التحكم
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadLogsAsync();
        }

        private void cmbSeverity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private async void btnClearOldLogs_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "هل أنت متأكد من رغبتك في تنظيف الأرشيف وحذف السجلات القديمة جداً (الأقدم من 90 يوماً)؟\nلا يمكن التراجع عن هذه الخطوة.",
                "تأكيد تنظيف الأرشيف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    btnClearOldLogs.Enabled = false;

                    int deletedCount = await _loggingService.ClearOldLogsAsync(keepDays: 90);

                    MessageBox.Show($"تم تنظيف الأرشيف بنجاح. وحذف {deletedCount} سجل قديم.", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await LoadLogsAsync(); // إعادة تحميل الجدول بعد الحذف
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء تنظيف الأرشيف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnClearOldLogs.Enabled = true;
                }
            }
        }
    }
}