using ClinicBusiness.DTO.PaymentsDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using ClinicManagementSystem.Invoices;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Finance
{
    public partial class frmPayments : Form
    {
        private readonly clsPayment _paymentService;
        private readonly clsInvoice _invoiceService;

        private int _selectedInvoiceId = -1;

        // متغير لتحديد وضع الفورم (إضافة: -1، تعديل: أي رقم آخر)
        private int _paymentId = -1;

        // نحتفظ برقم العملية الأصلي عند فتح وضع التعديل حتى لا يُفقد عند الحفظ
        private string _originalTransactionReference = null;

        public frmPayments(clsPayment paymentService, clsInvoice invoiceService, int paymentId = -1)
        {
            InitializeComponent();
            _paymentService = paymentService;
            _invoiceService = invoiceService;
            _paymentId = paymentId;

            btnChooseInvoice.Click += btnChooseInvoice_Click;
            btnNewPayment.Click += btnNewPayment_Click;

            txtAmountPaid.TextChanged += txtUpdateSummaryLabels_TextChanged;
            txtInvoiceTotal.TextChanged += txtUpdateSummaryLabels_TextChanged;
            txtAmountPaid.KeyPress += preventLetters_KeyPress;
        }

        private async void frmPayments_Load(object sender, EventArgs e)
        {
            cmbPaymentMethod.SelectedIndex = 0;

            if (_paymentId != -1)
            {
                await LoadPaymentDataForUpdateAsync();
            }
            else
            {
                ClearAllFields();
            }
        }

        // جلب بيانات الدفعة الحالية وتحميلها للواجهة بغرض التعديل
        private async Task LoadPaymentDataForUpdateAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                PaymentDetailsDTO payment = await _paymentService.GetPaymentByIdAsync(_paymentId);

                if (payment == null)
                {
                    MessageBox.Show("عذراً، لم يتم العثور على بيانات الدفعة المالية المطلوبة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                _selectedInvoiceId = payment.InvoiceId;
                txtInvoiceId.Text = _selectedInvoiceId.ToString();

                // نحتفظ برقم العملية الأصلي حتى لا نفقده عند الحفظ
                _originalTransactionReference = payment.TransactionReference;

                decimal invoiceFinalAmount = await _invoiceService.GetInvoiceFinalAmountAsync(_selectedInvoiceId);
                txtInvoiceTotal.Text = invoiceFinalAmount.ToString();

                txtAmountPaid.Text = payment.PaymentAmount.ToString();
                dtpPaymentDate.Value = payment.PaymentDate;
                txtNotes.Text = payment.Notes;

                // طريقة الدفع مخزّنة كنص، نختارها مباشرة بالاسم
                cmbPaymentMethod.Text = payment.PaymentMethod;

                UpdateSummaryAmountsLabels();

                btnSavePayment.Text = "تحديث الدفعة 💾";
                btnChooseInvoice.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات السداد للتعديل: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void btnChooseInvoice_Click(object sender, EventArgs e)
        {
            using (frmChooseInvoice frm = new frmChooseInvoice())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.WindowState = FormWindowState.Normal;
                    _selectedInvoiceId = frm.InvoiceId;
                    txtInvoiceId.Text = _selectedInvoiceId.ToString();

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

        // مربوطة من الـ Designer على txtRemainingAfterPayment.TextChanged
        private void txtAmount_TextChanged(object sender, EventArgs e)
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
            _paymentId = -1;
            _originalTransactionReference = null;
            btnSavePayment.Text = "حفظ الدفعة 💾";
            btnChooseInvoice.Enabled = true;

            ClearAllFields();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceId.Text))
            {
                MessageBox.Show("الرجاء اختيار فاتورة أولاً لإجراء الدفع عليها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAmountPaid.Text) ||
                !decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid) ||
                amountPaid <= 0)
            {
                MessageBox.Show("الرجاء إدخل مبلغ دفع صحيح أكبر من صفر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbPaymentMethod.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmbPaymentMethod.Text))
            {
                MessageBox.Show("الرجاء تحديد طريقة الدفع.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearAllFields()
        {
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

        private async void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (!IsFormValid()) return;

            if (_selectedInvoiceId == -1 || txtInvoiceId.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء اختيار الفاتورة المراد سدادها أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amountToPay = Convert.ToDecimal(txtAmountPaid.Text.Trim());

            btnSavePayment.Enabled = false;
            int invoiceId = Convert.ToInt32(txtInvoiceId.Text.Trim());

            string paymentMethodName = cmbPaymentMethod.Text;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (var freshContext = new ClinicManagementSystemContext())
                {
                    var isolatedInvoiceService = new clsInvoice(freshContext);
                    var isolatedPaymentService = new clsPayment(freshContext);

                    if (_paymentId == -1)
                    {
                        bool isPaid = await isolatedInvoiceService.IsInvoiceFullyPaidAsync(invoiceId);
                        if (isPaid)
                        {
                            MessageBox.Show("هذه الفاتورة مسددة بالكامل بالفعل ولا داعي لإضافة دفعة جديدة عليها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // منع الدفع الزائد: المبلغ المدخل يجب ألا يتجاوز المتبقي الفعلي على الفاتورة
                    decimal remainingBeforeThisPayment = await isolatedInvoiceService.GetInvoiceRemainingAmountAsync(
                        invoiceId,
                        excludePaymentId: _paymentId == -1 ? -1 : _paymentId);

                    if (amountToPay > remainingBeforeThisPayment)
                    {
                        MessageBox.Show(
                            $"المبلغ المدخل ({amountToPay:N2}$) أكبر من المتبقي الفعلي على الفاتورة ({remainingBeforeThisPayment:N2}$).",
                            "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    PaymentSaveDTO saveDto = new PaymentSaveDTO
                    {
                        PaymentId = _paymentId == -1 ? 0 : _paymentId,
                        InvoiceId = invoiceId,
                        PaymentAmount = amountToPay,
                        PaymentDate = dtpPaymentDate.Value,
                        PaymentMethod = paymentMethodName,
                        Notes = txtNotes.Text.Trim(),
                        TransactionReference = _paymentId == -1
                            ? "TXN-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper()
                            : _originalTransactionReference,
                        PaymentStatusId = 2,
                        IsActive = true
                    };

                    if (_paymentId == -1)
                    {
                        int newPaymentId = await isolatedPaymentService.AddNewPaymentAsync(saveDto);

                        if (newPaymentId > 0)
                        {
                            MessageBox.Show("تم حفظ الدفعة المالية وإصدار السداد بنجاح!", "نجاح عملية الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAllFields();
                        }
                        else
                        {
                            MessageBox.Show("حدث خطأ أثناء معالجة عملية الدفع. حاول مرة أخرى.", "خطأ مالي", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool isUpdated = await isolatedPaymentService.UpdatePaymentAsync(saveDto);

                        if (isUpdated)
                        {
                            MessageBox.Show("تم تحديث الدفعة المالية بنجاح!", "نجاح التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNewPayment_Click(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("حدث خطأ أثناء تحديث بيانات الدفعة، يرجى التحقق من المدخلات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ برمي أثناء معالجة العملية:\n{ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSavePayment.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }
    }
}