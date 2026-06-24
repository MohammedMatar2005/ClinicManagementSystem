using ClinicBusiness.DTO.InvoicesDTOs;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmInvoices : Form
    {
        // استخدام الأسماء الصريحة والمباشرة للخدمات المحقونة
        private readonly clsInvoice _invoiceService;
        private readonly clsPatientVisit _patientVisitService;

        // وسيط احترافي وبسيط للتحكم بالفلترة والترتيب داخل الـ Grid مباشرة بدون DataTable
        private BindingSource _invoicesBindingSource = new BindingSource();
        private List<InvoiceViewDTO> _originalInvoicesList = new List<InvoiceViewDTO>();

        private int _selectedPatientId = -1;

        // تمرير الخدمات مباشرة عبر الـ Constructor بناءً على المعمارية الجديدة
        public frmInvoices(clsInvoice invoiceService, clsPatientVisit patientVisitService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _patientVisitService = patientVisitService;
        }

        private async void frmInvoices_Load(object sender, EventArgs e)
        {
            ConfigureGridMapping();
            await LoadInvoicesDataAsync();
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

                // جلب البيانات مباشرة من الـ Service كـ List
                _originalInvoicesList = await _invoiceService.GetAllInvoicesAsync();

                // ربط القائمة بالـ BindingSource ثم بالـ Grid مباشرة دون الحاجة لـ DataTable
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // 1. التحققات الأولية للواجهة
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

                // 2. فحص البزنس: هل توجد فاتورة سابقة لهذه الزيارة؟
                if (await _invoiceService.IsInvoiceExistByVisitIdAsync(visitId))
                {
                    MessageBox.Show("عذراً، هذه الزيارة لديها فاتورة بالفعل ولا يمكن إصدار فاتورة أخرى لها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. بناء كائن الحفظ الـ DTO
                InvoiceSaveDTO saveDto = new InvoiceSaveDTO
                {
                    InvoiceId = 0,
                    VisitId = visitId,
                    ConsultationFee = string.IsNullOrEmpty(txtConsultationFee.Text) ? 0 : Convert.ToDecimal(txtConsultationFee.Text.Trim()),
                    LabTestFee = string.IsNullOrEmpty(txtLabTestFee.Text) ? 0 : Convert.ToDecimal(txtLabTestFee.Text.Trim()),
                    ProcedureFee = string.IsNullOrEmpty(txtProcedureFee.Text) ? 0 : Convert.ToDecimal(txtProcedureFee.Text.Trim()),
                    OtherCharges = string.IsNullOrEmpty(txtOtherCharges.Text) ? 0 : Convert.ToDecimal(txtOtherCharges.Text.Trim()),
                    DiscountPercentage = string.IsNullOrEmpty(txtDiscountPercentage.Text) ? 0 : Convert.ToDecimal(txtDiscountPercentage.Text.Trim()),
                    TaxPercentage = string.IsNullOrEmpty(txtTaxPercentage.Text) ? 0 : Convert.ToDecimal(txtTaxPercentage.Text.Trim()),
                    StatusId = 4, // افتراضي غير مدفوعة أو حسب النظام لديك
                    DueDate = DateOnly.FromDateTime(dtpDueDate.Value),
                    IsActive = true
                };

                // 4. استدعاء خدمة الحفظ في البزنس
                int newInvoiceId = await _invoiceService.AddNewInvoiceAsync(saveDto);

                if (newInvoiceId > 0)
                {
                    MessageBox.Show("تم حفظ الفاتورة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllFields();
                    await LoadInvoicesDataAsync(); // تحديث الجدول
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء حفظ الفاتورة. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ برمي أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
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
                // فلترة ذكية وسريعة باستخدام LINQ على القائمة الأصلية المتواجدة في الذاكرة
                var filtered = _originalInvoicesList
                    .Where(x => x.PatientFullName != null && x.PatientFullName.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                _invoicesBindingSource.DataSource = filtered;
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            // الحصول على القائمة الظاهرة حالياً للمستخدم (سواءً كاملة أو مفلترة)
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
                // الحصول على الـ DTO المربوط بالسطر المحدد مباشرة وبأمان تام
                InvoiceViewDTO selectedInvoice = (InvoiceViewDTO)dgvInvoices.SelectedRows[0].DataBoundItem;

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.FileName = $"فاتورة_{selectedInvoice.InvoiceNumber}_{selectedInvoice.PatientFullName.Replace(" ", "_")}";
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
            // السماح بالأرقام، مفتاح المسح الـ Backspace، والنقطة العشرية
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // منع تكرار النقطة العشرية
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txtPatientVisitId.Text))
            {
                MessageBox.Show("الرجاء اختيار زيارة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}