using ClinicBusiness.DTO.InvoicesDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness.Helpers;

namespace ClinicManagementSystem
{
    public partial class frmInvoices : Form
    {
        private readonly clsInvoice _invoiceService;
        private readonly clsPatientVisit _patientVisitService;

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

        // 4. دالة جلب بيانات الفاتورة المحددة وتحميلها في عناصر الواجهة لغرض التعديل
        private async Task LoadInvoiceDataForUpdateAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Invoice invoice = await _invoiceService.GetInvoiceByIdAsync(_invoiceId);

                if (invoice == null)
                {
                    MessageBox.Show("عذراً، لم يتم العثور على بيانات الفاتورة المطلوبة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                _originalInvoiceNumber = invoice.InvoiceNumber;
                _originalStatusId = invoice.StatusId;

                _selectedPatientId = invoice.VisitId;
                txtPatientVisitId.Text = invoice.VisitId.ToString();

                txtConsultationFee.Text = invoice.ConsultationFee.ToString("G0");
                txtLabTestFee.Text = invoice.LabTestFee.ToString("G0");
                txtProcedureFee.Text = invoice.ProcedureFee.ToString("G0");
                txtOtherCharges.Text = invoice.OtherCharges.ToString("G0");
                txtDiscountPercentage.Text = invoice.DiscountPercentage.ToString();
                txtTaxPercentage.Text = invoice.TaxPercentage.ToString();

                dtpDueDate.Value = invoice.DueDate.ToDateTime(TimeOnly.MinValue);

                UpdateSummaryAmountsLabels();

                btnSaveInvoice.Text = "تحديث الفاتورة";

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
            _invoiceId = -1;
            _originalInvoiceNumber = null;
            _originalStatusId = 4;
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

                if (_invoiceId == -1 && await _invoiceService.IsInvoiceExistByVisitIdAsync(visitId))
                {
                    MessageBox.Show("عذراً، هذه الزيارة لديها فاتورة بالفعل ولا يمكن إصدار فاتورة أخرى لها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InvoiceSaveDTO saveDto = new InvoiceSaveDTO
                {
                    InvoiceId = _invoiceId == -1 ? 0 : _invoiceId,
                    VisitId = visitId,

                    InvoiceNumber = _invoiceId == -1
                        ? InvoiceNumberGenerator.GenerateSemanticInvoiceNumber()
                        : _originalInvoiceNumber,

                    ConsultationFee = string.IsNullOrEmpty(txtConsultationFee.Text) ? 0 : Convert.ToDecimal(txtConsultationFee.Text.Trim()),
                    LabTestFee = string.IsNullOrEmpty(txtLabTestFee.Text) ? 0 : Convert.ToDecimal(txtLabTestFee.Text.Trim()),
                    ProcedureFee = string.IsNullOrEmpty(txtProcedureFee.Text) ? 0 : Convert.ToDecimal(txtProcedureFee.Text.Trim()),
                    OtherCharges = string.IsNullOrEmpty(txtOtherCharges.Text) ? 0 : Convert.ToDecimal(txtOtherCharges.Text.Trim()),
                    DiscountPercentage = string.IsNullOrEmpty(txtDiscountPercentage.Text) ? 0 : Convert.ToDecimal(txtDiscountPercentage.Text.Trim()),
                    TaxPercentage = string.IsNullOrEmpty(txtTaxPercentage.Text) ? 0 : Convert.ToDecimal(txtTaxPercentage.Text.Trim()),

                    StatusId = _invoiceId == -1 ? (byte)4 : _originalStatusId,

                    DueDate = DateOnly.FromDateTime(dtpDueDate.Value),
                    IsActive = true
                };

                if (_invoiceId == -1)
                {
                    int newInvoiceId = await _invoiceService.AddNewInvoiceAsync(saveDto);

                    if (newInvoiceId > 0)
                    {
                        MessageBox.Show("تم حفظ الفاتورة الجديدة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllFields();
                    }
                    else
                    {
                        MessageBox.Show("حدث خطأ أثناء حفظ الفاتورة. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool isUpdated = await _invoiceService.UpdateInvoiceAsync(saveDto);

                    if (isUpdated)
                    {
                        MessageBox.Show("تم تحديث بيانات الفاتورة بنجاح!", "نجاح التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNewInvoice_Click(null, null);
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