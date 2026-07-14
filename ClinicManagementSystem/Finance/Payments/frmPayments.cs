using ClinicBusiness.DTO.PaymentsDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using ClinicManagementSystem.Invoices;
using Microsoft.EntityFrameworkCore; // تأكد من وجودها
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Finance
{
    public partial class frmPayments : Form
    {
        private readonly clsPayment _paymentService;
        private readonly clsInvoice _invoiceService;

        private BindingSource _paymentsBindingSource = new BindingSource();
        private List<PaymentViewDTO> _originalPaymentsList = new List<PaymentViewDTO>();

        private int _selectedInvoiceId = -1;

        public frmPayments(clsPayment paymentService, clsInvoice invoiceService)
        {
            InitializeComponent();
            _paymentService = paymentService;
            _invoiceService = invoiceService;

            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            btnExportPdf.Click += btnExportPdf_Click;
            btnExportThisPayment.Click += btnExportThisPayment_Click;
            btnChooseInvoice.Click += btnChooseInvoice_Click;
            btnNewPayment.Click += btnNewPayment_Click;
            btnSavePayment.Click += btnSavePayment_Click_1;

            txtAmountPaid.TextChanged += txtUpdateSummaryLabels_TextChanged;
            txtInvoiceTotal.TextChanged += txtUpdateSummaryLabels_TextChanged;
            txtAmountPaid.KeyPress += preventLetters_KeyPress;
        }

        private async void frmPayments_Load(object sender, EventArgs e)
        {
            ConfigureGridMapping();
            await LoadPaymentsDataAsync();
        }

        private void ConfigureGridMapping()
        {
            dgvPayments.AutoGenerateColumns = false;

            colPaymentId.DataPropertyName = "PaymentId";
            colPatientName.DataPropertyName = "PatientFullName";
            colInvoiceNumber.DataPropertyName = "InvoiceNumber";
            colAmountPaid.DataPropertyName = "AmountPaid";
            colPaymentDate.DataPropertyName = "PaymentDate";
            colPaymentMethod.DataPropertyName = "PaymentMethodName";
        }

        private async Task LoadPaymentsDataAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // جلب البيانات بنسخة منفصلة للأمان التام أثناء التنقل في الواجهات
                // في بيئة الـ Desktop يفضل دوماً جلب الـ Lists بنسخ سريعة غير مشتركة
                _originalPaymentsList = await _paymentService.GetAllPaymentsAsync();

                _paymentsBindingSource.DataSource = _originalPaymentsList;
                dgvPayments.DataSource = _paymentsBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب الدفعات من السيرفر: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void UpdateSummaryAmountsLabels()
        {
            decimal.TryParse(txtInvoiceTotal.Text, out decimal invoiceAmount);
            decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid);

            decimal remainingAmount = invoiceAmount - amountPaid;
            if (remainingAmount < 0) remainingAmount = 0;

            txtRemainingAfterPayment.Text = remainingAmount.ToString();

            lblAmountPaidNowValue.Text = $"{amountPaid:N2}$";
            lblRemainingValue.Text = $"{remainingAmount:N2}$";
            txtPaidSoFar.Text = (invoiceAmount - remainingAmount).ToString();
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchValue.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                _paymentsBindingSource.DataSource = _originalPaymentsList;
            }
            else
            {
                var filtered = _originalPaymentsList
                    .Where(x => x.PatientFullName != null && x.PatientFullName.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                _paymentsBindingSource.DataSource = filtered;
            }
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

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.FileName = $"إيصال_دفع_{selectedPayment.PaymentId}_{selectedPayment.PatientFullName.Replace(" ", "_")}";
                    sfd.Title = "حفظ إيصال السداد بصيغة PDF";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("تم تصدير إيصال السداد بنجاح!", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تصدير الإيصال: {ex.Message}", "خطأ في التصدير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnChooseInvoice_Click(object sender, EventArgs e)
        {
            using (frmChooseInvoice frm = new frmChooseInvoice())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.WindowState = FormWindowState.Normal;
                    _selectedInvoiceId = frm.InvoiceId;
                    txtInvoiceId.Text = _selectedInvoiceId.ToString();

                    // هنا قراءة آمنة للقيمة الكلية
                    decimal invoiceFinalAmount = await _invoiceService.GetInvoiceFinalAmountAsync(_selectedInvoiceId);
                    txtInvoiceTotal.Text = invoiceFinalAmount.ToString();

                    UpdateSummaryAmountsLabels();
                }
            }
        }

        private void txtUpdateSummaryLabels_TextChanged(object sender, EventArgs e)
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

        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceId.Text))
            {
                MessageBox.Show("الرجاء اختيار فاتورة أولاً لإجراء الدفع عليها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAmountPaid.Text) || Convert.ToDecimal(txtAmountPaid.Text) <= 0)
            {
                MessageBox.Show("الرجاء إدخل مبلغ دفع صحيح أكبر من صفر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد طريقة الدفع.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearAllFields()
        {
            txtSearchValue.Clear();
            _paymentsBindingSource.DataSource = _originalPaymentsList;

            _selectedInvoiceId = -1;
            txtInvoiceId.Clear();
            txtInvoiceTotal.Text = "0";
            txtPaidSoFar.Text = "0";
            txtAmountPaid.Text = "0";
            txtRemainingAfterPayment.Text = "0";
            txtNotes.Clear();

            if (cmbPaymentMethod.Items.Count > 0)
                cmbPaymentMethod.SelectedIndex = 0;

            dtpPaymentDate.Value = DateTime.Now;
            UpdateSummaryAmountsLabels();
        }

        // 🛠️ تم تعديل دالة الحفظ بالكامل لحل مشكلة الـ DbContext الـ Multi-threaded والتصادم التزامني
        private async void btnSavePayment_Click_1(object sender, EventArgs e)
        {
            if (!IsFormValid()) return;

            if (_selectedInvoiceId == -1 || txtInvoiceId.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء اختيار الفاتورة المراد سدادها أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSavePayment.Enabled = false;
            int invoiceId = Convert.ToInt32(txtInvoiceId.Text.Trim());
            int? paymentMethod = cmbPaymentMethod.SelectedValue != null ? Convert.ToInt32(cmbPaymentMethod.SelectedValue) : 1;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                // 💡 الحل الجذري: نفتح نفق اتصال طازج ومعزول (freshContext) لكل العمليات داخل زر الحفظ
                using (var freshContext = new ClinicManagementSystemContext())
                {
                    // 1. ننشئ نسخ مؤقتة محلياً مبنية على الـ Context النظيف
                    var isolatedInvoiceService = new clsInvoice(freshContext);
                    var isolatedPaymentService = new clsPayment(freshContext);

                    // 2. فحص البزنس المالي بشكل آمن تماماً وبدون تداخل
                    bool isPaid = await isolatedInvoiceService.IsInvoiceFullyPaidAsync(invoiceId);
                    if (isPaid)
                    {
                        MessageBox.Show("هذه الفاتورة مسددة بالكامل بالفعل ولا داعي لإضافة دفعة جديدة عليها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 3. بناء كائن الحفظ DTO
                    PaymentSaveDTO saveDto = new PaymentSaveDTO
                    {
                        PaymentId = 0,
                        InvoiceId = invoiceId,
                        PaymentAmount = Convert.ToDecimal(txtAmountPaid.Text.Trim()),
                        PaymentDate = dtpPaymentDate.Value,
                        PaymentMethod = paymentMethod?.ToString() ?? "نقداً",
                        Notes = txtNotes.Text.Trim(),
                        TransactionReference = "TXN-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                        IsActive = true
                    };

                    // 4. تنفيذ الحفظ على نفس الاتصال النظيف
                    int newPaymentId = await isolatedPaymentService.AddNewPaymentAsync(saveDto);

                    if (newPaymentId > 0)
                    {
                        MessageBox.Show("تم حفظ الدفعة المالية وإصدار السداد بنجاح!", "نجاح عملية الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllFields();
                        await LoadPaymentsDataAsync(); // تحديث الجدول (هذه الدالة تستخدم دالتها الخاصة الآمنة)
                    }
                    else
                    {
                        MessageBox.Show("حدث خطأ أثناء معالجة عملية الدفع. حاول مرة أخرى.", "خطأ مالي", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ برمي أثناء معالجة السداد:\n{ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSavePayment.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }
    }
}