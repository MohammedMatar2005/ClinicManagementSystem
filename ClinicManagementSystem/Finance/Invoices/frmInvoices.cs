using ClinicBusiness.DTO.InvoicesDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness.Utils;
using ClinicBusiness.Helpers;

namespace ClinicManagementSystem
{
    public partial class frmInvoices : Form
    {
        private readonly clsInvoice _invoiceService;
        private readonly clsPatientVisit _patientVisitService;

        private BindingSource _invoicesBindingSource = new BindingSource();
        private List<InvoiceViewDTO> _originalInvoicesList = new List<InvoiceViewDTO>();

        private int _selectedPatientId = -1;

        // 1. متغير لتحديد وضع الفورم (إضافة: -1، تعديل: أي رقم آخر)
        private int _invoiceId = -1;

        // نحتفظ برقم الفاتورة وحالتها الأصليين عند فتح وضع التعديل، حتى لا يتغيرا بالخطأ
        private string _originalInvoiceNumber = null;
        private byte _originalStatusId = 4;

        // 2. تحديث الباني ليستقبل الـ Id كبارامتر اختياري
        public frmInvoices(clsInvoice invoiceService, clsPatientVisit patientVisitService, int invoiceId = -1)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _patientVisitService = patientVisitService;
            _invoiceId = invoiceId;
        }

        private async void frmInvoices_Load(object sender, EventArgs e)
        {
            ConfigureGridMapping();
            await LoadInvoicesDataAsync();

            // 3. الفحص عند تحميل الفورم: هل هو تعديل أم إضافة؟
            if (_invoiceId != -1)
            {
                await LoadInvoiceDataForUpdateAsync();
            }
            else
            {
                ClearAllFields(); // وضع الإضافة الافتراضي
            }
        }

        private void ConfigureGridMapping()
        {
            dgvInvoices.AutoGenerateColumns = false;

            colInvoiceId.DataPropertyName = "InvoiceId";
            colPatientName.DataPropertyName = "PatientFullName";
            colFinalAmount.DataPropertyName = "FinalAmount";
            colInvoiceDate.DataPropertyName = "InvoiceDate";
            colInvoiceNumber.DataPropertyName = "InvoiceNumber";
        }

        private async Task LoadInvoicesDataAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                _originalInvoicesList = await _invoiceService.GetAllInvoicesAsync();
                _invoicesBindingSource.DataSource = _originalInvoicesList;
                dgvInvoices.DataSource = _invoicesBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب الفواتير من السيرفر: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // 4. دالة جلب بيانات الفاتورة المحددة وتحميلها في عناصر الواجهة لغرض التعديل
        private async Task LoadInvoiceDataForUpdateAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // جلب كائن الحفظ أو تفاصيل الفاتورة من السيرفر (افترضنا أن الخدمة توفر دالة GetById)
                Invoice invoice = await _invoiceService.GetInvoiceByIdAsync(_invoiceId);

                if (invoice == null)
                {
                    MessageBox.Show("عذراً، لم يتم العثور على بيانات الفاتورة المطلوبة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // نحتفظ برقم الفاتورة وحالتها الأصليين لإرسالهما دون تغيير عند الحفظ لاحقاً
                _originalInvoiceNumber = invoice.InvoiceNumber;
                _originalStatusId = invoice.StatusId;

                // تعبئة عناصر التحكم بالبيانات القادمة من السيرفر
                _selectedPatientId = invoice.VisitId;
                txtPatientVisitId.Text = invoice.VisitId.ToString();

                txtConsultationFee.Text = invoice.ConsultationFee.ToString("G0");
                txtLabTestFee.Text = invoice.LabTestFee.ToString("G0");
                txtProcedureFee.Text = invoice.ProcedureFee.ToString("G0");
                txtOtherCharges.Text = invoice.OtherCharges.ToString("G0");
                txtDiscountPercentage.Text = invoice.DiscountPercentage.ToString();
                txtTaxPercentage.Text = invoice.TaxPercentage.ToString();

                // تحويل DateOnly إلى DateTime ليقبلها الـ DateTimePicker
                dtpDueDate.Value = invoice.DueDate.ToDateTime(TimeOnly.MinValue);

                // تحديث الحسابات والـ Labels تلقائياً بعد ملء الخانات
                UpdateSummaryAmountsLabels();

                // تغيير هوية الواجهة لتعكس وضع التعديل (UX ممتازة للطبيب/المستخدم)
                tabNewInvoice.Text = "تعديل بيانات الفاتورة الحالية"; // افترضت وجود تسمية للعنوان أعلى الفورم
                btnSaveInvoice.Text = "تحديث الفاتورة";

                // في وضع التعديل يفضل قفل زر اختيار الزيارة لمنع تغيير الفاتورة لزيارة أخرى كقاعدة بزنس ثابته
                btnChooseVisit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الفاتورة للتعديل: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void UpdateSummaryAmountsLabels()
        {
            decimal.TryParse(txtConsultationFee.Text, out decimal consultation);
            decimal.TryParse(txtLabTestFee.Text, out decimal labTest);
            decimal.TryParse(txtProcedureFee.Text, out decimal procedure);
            decimal.TryParse(txtOtherCharges.Text, out decimal other);

            decimal.TryParse(txtDiscountPercentage.Text, out decimal discountPercentage);
            decimal.TryParse(txtTaxPercentage.Text, out decimal taxPercentage);

            decimal subTotal = consultation + labTest + procedure + other;
            decimal discountAmount = subTotal * (discountPercentage / 100);
            decimal taxAmount = subTotal * (taxPercentage / 100);
            decimal finalAmount = subTotal - discountAmount + taxAmount;

            lblSubTotalValue.Text = $"{subTotal:N2}$";
            lblDiscountAmtValue.Text = $"-{discountAmount:N2}$";
            lblFinalTotalValue.Text = $"{finalAmount:N2}$";
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchValue.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                _invoicesBindingSource.DataSource = _originalInvoicesList;
            }
            else
            {
                var filtered = _originalInvoicesList
                    .Where(x => x.PatientFullName != null && x.PatientFullName.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                _invoicesBindingSource.DataSource = filtered;
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            var currentList = _invoicesBindingSource.List.Cast<InvoiceViewDTO>().ToList();

            if (currentList == null || currentList.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات فواتير حالية لتصديرها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = $"تقرير_الفواتير_الشامل_{DateTime.Now:yyyyMMdd}";
                sfd.Title = "حفظ تقرير الفواتير الشامل بصيغة PDF";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ClinicBusiness.Utils.ExportPDF.GenerateAllInvoicesTablePDF(currentList, sfd.FileName);
                        MessageBox.Show("تم تصدير التقرير بنجاح!", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"حدث خطأ أثناء حفظ ملف التقرير: {ex.Message}", "خطأ في التصدير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExportThisInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد الفاتورة المراد تصديرها من الجدول أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                InvoiceViewDTO selectedInvoice = (InvoiceViewDTO)dgvInvoices.SelectedRows[0].DataBoundItem;

                // حماية من NullReferenceException لو اسم المريض فارغ
                string safePatientName = string.IsNullOrWhiteSpace(selectedInvoice.PatientFullName)
                    ? "غير_معروف"
                    : selectedInvoice.PatientFullName.Replace(" ", "_");

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.FileName = $"فاتورة_{selectedInvoice.InvoiceNumber}_{safePatientName}";
                    sfd.Title = "حفظ الفاتورة التفصيلية بصيغة PDF";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ClinicBusiness.Utils.ExportPDF.GenerateSingleInvoicePDF(selectedInvoice, sfd.FileName);
                        MessageBox.Show("تم تصدير الفاتورة التفصيلية بنجاح!", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تصدير الفاتورة الفردية: {ex.Message}", "خطأ في التصدير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseVisit_Click(object sender, EventArgs e)
        {
            using (frmChoosePatientVisit frm = new frmChoosePatientVisit())
            {

                frm.StartPosition = FormStartPosition.CenterParent;
                frm.WindowState = FormWindowState.Normal;
                if (frm.ShowDialog() == DialogResult.OK)
                {


                    _selectedPatientId = frm.PatientVisitId;
                    txtPatientVisitId.Text = _selectedPatientId.ToString();
                }
            }
        }

        private void txtUpdateSummaryLables_TextChanged(object sender, EventArgs e)
        {
            UpdateSummaryAmountsLabels();
        }

        private void preventLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            // إعادة الفورم لوضع الإضافة الأصلي
            _invoiceId = -1;
            _originalInvoiceNumber = null;
            _originalStatusId = 4;
            if (tabNewInvoice != null) tabNewInvoice.Text = "إصدار فاتورة جديدة";
            btnSaveInvoice.Text = "حفظ الفاتورة";
            btnChooseVisit.Enabled = true;

            ClearAllFields();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txtPatientVisitId.Text))
            {
                MessageBox.Show("الرجاء اختيار زيارة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // التحقق من صحة الحقول الرقمية بدل الاعتماد على Convert.ToDecimal لاحقاً بدون فحص
            if (!string.IsNullOrWhiteSpace(txtConsultationFee.Text) && !decimal.TryParse(txtConsultationFee.Text, out _))
            {
                MessageBox.Show("قيمة رسوم الاستشارة غير صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtLabTestFee.Text) && !decimal.TryParse(txtLabTestFee.Text, out _))
            {
                MessageBox.Show("قيمة رسوم التحاليل غير صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtProcedureFee.Text) && !decimal.TryParse(txtProcedureFee.Text, out _))
            {
                MessageBox.Show("قيمة رسوم الإجراء غير صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtOtherCharges.Text) && !decimal.TryParse(txtOtherCharges.Text, out _))
            {
                MessageBox.Show("قيمة الرسوم الأخرى غير صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // نسب الخصم والضريبة يجب أن تكون منطقية بين 0 و100
            if (!decimal.TryParse(txtDiscountPercentage.Text, out decimal discountPct) || discountPct < 0 || discountPct > 100)
            {
                MessageBox.Show("نسبة الخصم يجب أن تكون بين 0 و100.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtTaxPercentage.Text, out decimal taxPct) || taxPct < 0 || taxPct > 100)
            {
                MessageBox.Show("نسبة الضريبة يجب أن تكون بين 0 و100.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearAllFields()
        {
            txtSearchValue.Clear();
            _invoicesBindingSource.DataSource = _originalInvoicesList;

            _selectedPatientId = -1;
            txtPatientVisitId.Clear();

            txtDiscountPercentage.Text = "0";
            txtTaxPercentage.Text = "0";
            txtConsultationFee.Text = "0";
            txtLabTestFee.Text = "0";
            txtOtherCharges.Text = "0";
            txtProcedureFee.Text = "0";

            dtpDueDate.Value = DateTime.Now.AddDays(7);
            UpdateSummaryAmountsLabels();
        }

        // 5. تعديل ميثود الحفظ لتتعامل مع حالتي الإضافة والتعديل بذكاء
        private async void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (!IsFormValid()) return;

            if (_selectedPatientId == -1)
            {
                MessageBox.Show("الرجاء اختيار مريض أولاً لإصدار الفاتورة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int visitId = Convert.ToInt32(txtPatientVisitId.Text.Trim());

            try
            {
                this.Cursor = Cursors.WaitCursor;

                // فحص البزنس الخاص بالإضافة فقط (منع تكرار فاتورة لنفس الزيارة)
                if (_invoiceId == -1 && await _invoiceService.IsInvoiceExistByVisitIdAsync(visitId))
                {
                    MessageBox.Show("عذراً، هذه الزيارة لديها فاتورة بالفعل ولا يمكن إصدار فاتورة أخرى لها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // بناء كائن الحفظ الـ DTO وتمرير الـ _invoiceId الحالي له (0 للإضافة أو القيمة الفعلية للتعديل)
                InvoiceSaveDTO saveDto = new InvoiceSaveDTO
                {
                    InvoiceId = _invoiceId == -1 ? 0 : _invoiceId,
                    VisitId = visitId,

                    // رقم الفاتورة: يُولَّد مرة واحدة فقط عند الإنشاء.
                    // عند التعديل، نُعيد إرسال الرقم الأصلي القديم كما هو ولا نولّد رقماً جديداً أبداً.
                    InvoiceNumber = _invoiceId == -1
                        ? InvoiceNumberGenerator.GenerateSemanticInvoiceNumber()
                        : _originalInvoiceNumber,

                    ConsultationFee = string.IsNullOrEmpty(txtConsultationFee.Text) ? 0 : Convert.ToDecimal(txtConsultationFee.Text.Trim()),
                    LabTestFee = string.IsNullOrEmpty(txtLabTestFee.Text) ? 0 : Convert.ToDecimal(txtLabTestFee.Text.Trim()),
                    ProcedureFee = string.IsNullOrEmpty(txtProcedureFee.Text) ? 0 : Convert.ToDecimal(txtProcedureFee.Text.Trim()),
                    OtherCharges = string.IsNullOrEmpty(txtOtherCharges.Text) ? 0 : Convert.ToDecimal(txtOtherCharges.Text.Trim()),
                    DiscountPercentage = string.IsNullOrEmpty(txtDiscountPercentage.Text) ? 0 : Convert.ToDecimal(txtDiscountPercentage.Text.Trim()),
                    TaxPercentage = string.IsNullOrEmpty(txtTaxPercentage.Text) ? 0 : Convert.ToDecimal(txtTaxPercentage.Text.Trim()),

                    // حالة الفاتورة: تكون 4 (افتراضية) عند الإنشاء فقط.
                    // عند التعديل، نحافظ على الحالة الأصلية الحالية للفاتورة ولا نصفّرها.
                    StatusId = _invoiceId == -1 ? (byte)4 : _originalStatusId,

                    DueDate = DateOnly.FromDateTime(dtpDueDate.Value),
                    IsActive = true
                };

                if (_invoiceId == -1)
                {
                    // ================= وضع الإضافة =================
                    int newInvoiceId = await _invoiceService.AddNewInvoiceAsync(saveDto);

                    if (newInvoiceId > 0)
                    {
                        MessageBox.Show("تم حفظ الفاتورة الجديدة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllFields();
                        await LoadInvoicesDataAsync();
                    }
                    else
                    {
                        MessageBox.Show("حدث خطأ أثناء حفظ الفاتورة. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // ================= وضع التعديل =================
                    // استدعاء خدمة التحديث في البزنس (افترضنا أن الخدمة توفر دالة UpdateInvoiceAsync)
                    bool isUpdated = await _invoiceService.UpdateInvoiceAsync(saveDto);

                    if (isUpdated)
                    {
                        MessageBox.Show("تم تحديث بيانات الفاتورة بنجاح!", "نجاح التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // إعادة تهيئة الواجهة للوضع الافتراضي بعد النجاح
                        btnNewInvoice_Click(null, null);
                        await LoadInvoicesDataAsync(); // تحديث الجدول لعرض البيانات الجديدة
                    }
                    else
                    {
                        MessageBox.Show("حدث خطأ أثناء تحديث الفاتورة، يرجى التحقق من المدخلات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ برمي أثناء العملية: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

    }
}