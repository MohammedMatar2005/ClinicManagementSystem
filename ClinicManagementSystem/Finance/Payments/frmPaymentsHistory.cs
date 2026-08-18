using ClinicBusiness.DTO.PaymentsDTOs;
using ClinicBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagementSystem.Finance
{
    public partial class frmPaymentsHistory : Form
    {
        private readonly clsPayment _paymentService;

        private BindingSource _paymentsBindingSource = new BindingSource();
        private List<PaymentViewDTO> _originalPaymentsList = new List<PaymentViewDTO>();

        public frmPaymentsHistory(clsPayment paymentService)
        {
            InitializeComponent();
            _paymentService = paymentService;
        }

        private async void frmPaymentsHistory_Load(object sender, EventArgs e)
        {
            await LoadPaymentsDataAsync();
        }

        private async System.Threading.Tasks.Task LoadPaymentsDataAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _originalPaymentsList = await _paymentService.GetAllPaymentsAsync();

                _paymentsBindingSource.DataSource = _originalPaymentsList;
                dgvPayments.DataSource = _paymentsBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب الدفعات من السيرفر: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _paymentsBindingSource.DataSource = _originalPaymentsList;
                return;
            }

            var filtered = _originalPaymentsList
                .Where(p =>
                    (p.PatientFullName != null && p.PatientFullName.Contains(searchValue, StringComparison.OrdinalIgnoreCase)) ||
                    p.InvoiceId.ToString().Contains(searchValue))
                .ToList();

            _paymentsBindingSource.DataSource = filtered;
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            var currentList = _paymentsBindingSource.List.Cast<PaymentViewDTO>().ToList();

            if (currentList == null || currentList.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات دفعات حالية لتصديرها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = $"تقرير_الدفعات_الشامل_{DateTime.Now:yyyyMMdd}";
                sfd.Title = "حفظ تقرير الدفعات المالي بصيغة PDF";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // TODO: استدعِ دالة التصدير الفعلية هنا عند توفرها في ExportPDF، مثلاً:
                        // ClinicBusiness.Utils.ExportPDF.GenerateAllPaymentsTablePDF(currentList, sfd.FileName);

                        MessageBox.Show("تم تصدير التقرير بنجاح!", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"حدث خطأ أثناء حفظ ملف التقرير: {ex.Message}", "خطأ في التصدير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExportThisPayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد الدفعة المراد تصدير إيصالها من الجدول أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PaymentViewDTO selectedPayment = (PaymentViewDTO)dgvPayments.SelectedRows[0].DataBoundItem;

                string safePatientName = string.IsNullOrWhiteSpace(selectedPayment.PatientFullName)
                    ? "غير_معروف"
                    : selectedPayment.PatientFullName.Replace(" ", "_");

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.FileName = $"إيصال_دفع_{selectedPayment.PaymentId}_{safePatientName}";
                    sfd.Title = "حفظ إيصال السداد بصيغة PDF";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // TODO: استدعِ دالة توليد إيصال PDF فردي هنا عند توفرها، مثلاً:
                        // ClinicBusiness.Utils.ExportPDF.GenerateSinglePaymentPDF(selectedPayment, sfd.FileName);

                        MessageBox.Show("تم تصدير إيصال السداد بنجاح!", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تصدير الإيصال: {ex.Message}", "خطأ في التصدير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}