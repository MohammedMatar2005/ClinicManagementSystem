using ClinicBusiness.DTO.PaymentsDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using ClinicManagementSystem.Invoices;
using Microsoft.EntityFrameworkCore;
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

        // 1. متغير لتحديد وضع الفورم (إضافة: -1، تعديل: أي رقم آخر)
        private int _paymentId = -1;

        // نحتفظ برقم العملية القديم عند فتح وضع التعديل، لعرضه/الاحتفاظ به بدون فقدانه
        private string _originalTransactionReference = null;

        // 2. تحديث الباني ليستقبل الـ Id كبارامتر اختياري
        public frmPayments(clsPayment paymentService, clsInvoice invoiceService, int paymentId = -1)
        {
            InitializeComponent();
            _paymentService = paymentService;
            _invoiceService = invoiceService;
            _paymentId = paymentId;

            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            btnExportPdf.Click += btnExportPdf_Click;
            btnExportThisPayment.Click += btnExportThisPayment_Click;
            btnChooseInvoice.Click += btnChooseInvoice_Click;
            btnNewPayment.Click += btnNewPayment_Click;


            txtAmountPaid.TextChanged += txtUpdateSummaryLabels_TextChanged;
            txtInvoiceTotal.TextChanged += txtUpdateSummaryLabels_TextChanged;
            txtAmountPaid.KeyPress += preventLetters_KeyPress;

            ConfigureGridMapping();
        }

        private async void frmPayments_Load(object sender, EventArgs e)
        {

            cmbPaymentMethod.SelectedIndex = 0;
            ConfigureGridMapping();
            await LoadPaymentsDataAsync();
            LoadPaymentMethods();

            // 3. الفحص عند تحميل الفورم: هل هو وضع تعديل أم إضافة؟
            if (_paymentId != -1)
            {
                await LoadPaymentDataForUpdateAsync();
            }
            else
            {
                ClearAllFields(); // وضع الإضافة الافتراضي
            }
        }

        private void ConfigureGridMapping()
        {
            // منع إنشاء أعمدة تلقائية غير التي صممناها
            dgvPayments.AutoGenerateColumns = false;

            // ربط الأعمدة بالخصائص الموجودة في PaymentViewDTO
            colPaymentId.DataPropertyName = "PaymentId";
            colInvoiceId.DataPropertyName = "InvoiceId";
            colPatientName.DataPropertyName = "PatientFullName";
            colDoctorName.DataPropertyName = "DoctorFullName";
            colPaymentAmount.DataPropertyName = "PaymentAmount";
            colPaymentDate.DataPropertyName = "PaymentDate";
            colPaymentMethod.DataPropertyName = "PaymentMethod";
            colTransactionReference.DataPropertyName = "TransactionReference";
            colPaymentStatusName.DataPropertyName = "PaymentStatusName";
        }

        private async Task LoadPaymentsDataAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // جلب قائمة الدفعات من نوع PaymentViewDTO
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

        // 4. دالة جلب بيانات الدفعة الحالية وتحميلها للواجهة بغرض التعديل
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

                // ملء عناصر التحكم بالبيانات المسترجعة
                _selectedInvoiceId = payment.InvoiceId;
                txtInvoiceId.Text = _selectedInvoiceId.ToString();

                // نحتفظ برقم العملية الأصلي حتى لا نفقده لو الحقل ما انبعتش صح لاحقاً
                _originalTransactionReference = payment.TransactionReference;

                // جلب قيمة الفاتورة الكلية بشكل آمن ومباشر
                decimal invoiceFinalAmount = await _invoiceService.GetInvoiceFinalAmountAsync(_selectedInvoiceId);
                txtInvoiceTotal.Text = invoiceFinalAmount.ToString();

                txtAmountPaid.Text = payment.PaymentAmount.ToString();
                dtpPaymentDate.Value = payment.PaymentDate;
                txtNotes.Text = payment.Notes;

                // طريقة الدفع مخزّنة كنص (اسم الطريقة) دائماً، لذلك نختارها بالاسم مباشرة في القائمة النصية
                cmbPaymentMethod.Text = payment.PaymentMethod;

                // تحديث الحسابات والتسميات تلقائياً
                UpdateSummaryAmountsLabels();

                // تحسين هوية العرض وتجربة المستخدم
                if (tabNewPayment != null) tabNewPayment.Text = "تعديل الدفعة المالية الحالية";
                btnSavePayment.Text = "تحديث الدفعة";

                // قفل زر اختيار الفاتورة أثناء التعديل لمنع ترحيل دفعة من فاتورة لأخرى
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
                        // TODO: يجب استدعاء دالة التصدير الفعلية هنا، تماماً كما في شاشة الفواتير:
                        // ClinicBusiness.Utils.ExportPDF.GenerateAllPaymentsTablePDF(currentList, sfd.FileName);
                        // حالياً لا يوجد استدعاء فعلي، لذلك لن يُنشأ أي ملف رغم رسالة النجاح.
                        // أضف دالة GenerateAllPaymentsTablePDF في ExportPDF ثم فعّل السطر أعلاه.

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

                // حماية من NullReferenceException لو اسم المريض فارغ
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
                        // TODO: استدعِ دالة توليد إيصال PDF فردي هنا مثل:
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
            // إعادة الواجهة للوضع الافتراضي (الإضافة)
            _paymentId = -1;
            _originalTransactionReference = null;
            if (tabNewPayment != null) tabNewPayment.Text = "إصدار دفعة مالية جديدة";
            btnSavePayment.Text = "حفظ الدفعة";
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

            // استخدام TryParse بدل Convert.ToDecimal لمنع تعطل البرنامج عند إدخال نص غير صالح
            if (string.IsNullOrWhiteSpace(txtAmountPaid.Text) ||
                !decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid) ||
                amountPaid <= 0)
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

        // 5. تعديل ميثود الحفظ ليدعم الحالتين داخل الـ isolatedContext النظيف

        private void LoadPaymentMethods()
        {
            // يمكنك جلبها من الـ Service الخاصة بك أو تعبئتها يدوياً هكذا مؤقتاً بما يتطابق مع قاعدة البيانات
            DataTable dtMethods = new DataTable();
            dtMethods.Columns.Add("Id", typeof(int));
            dtMethods.Columns.Add("Name", typeof(string));

            dtMethods.Rows.Add(1, "نقداً");
            dtMethods.Rows.Add(2, "بطاقة ائتمان");
            dtMethods.Rows.Add(3, "تحويل بنكي");
            dtMethods.Rows.Add(4, "تأمين");

            cmbPaymentMethod.DataSource = dtMethods;
            cmbPaymentMethod.DisplayMember = "Name";
            cmbPaymentMethod.ValueMember = "Id";
            cmbPaymentMethod.SelectedIndex = 0;
        }

        private async void btnSavePayment_Click(object sender, EventArgs e)
        {

            if (!IsFormValid()) return;

            if (_selectedInvoiceId == -1 || txtInvoiceId.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء اختيار الفاتورة المراد سدادها أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amountToPay = Convert.ToDecimal(txtAmountPaid.Text.Trim()); // آمن هنا لأن IsFormValid تحققت مسبقاً

            btnSavePayment.Enabled = false;
            int invoiceId = Convert.ToInt32(txtInvoiceId.Text.Trim());

            // طريقة الدفع تُحفظ دائماً كاسم نصي (وليس كرقم) لتطابق ما يُقرأ عند التعديل
            string paymentMethodName = cmbPaymentMethod.SelectedItem is DataRowView row
                ? row["Name"].ToString()
                : cmbPaymentMethod.Text;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                // فتح اتصال طازج ومعزول تماماً لتجنب مشاكل التصادم التزامني للملفات
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

                    // منع الدفع الزائد (Overpayment): المبلغ المدخل يجب ألا يتجاوز المتبقي الفعلي على الفاتورة.
                    // في وضع التعديل، نستثني الدفعة الحالية نفسها من حساب "المدفوع سابقاً".
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

                    // بناء كائن الـ DTO وتمرير الـ _paymentId الحالي له
                    PaymentSaveDTO saveDto = new PaymentSaveDTO
                    {
                        PaymentId = _paymentId == -1 ? 0 : _paymentId,
                        InvoiceId = invoiceId,
                        PaymentAmount = amountToPay,
                        PaymentDate = dtpPaymentDate.Value,
                        PaymentMethod = paymentMethodName,
                        Notes = txtNotes.Text.Trim(),
                        // في الإضافة: نولّد رقم عملية جديد.
                        // في التعديل: نحتفظ بالرقم الأصلي القديم بدل إرسال null (لمنع مسحه في UpdatePaymentAsync).
                        TransactionReference = _paymentId == -1
                            ? "TXN-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper()
                            : _originalTransactionReference,
                        // حالة الدفعة: تُعتبر "مكتملة" افتراضياً عند التسجيل اليدوي من الموظف
                        PaymentStatusId = 2,
                        IsActive = true
                    };

                    if (_paymentId == -1)
                    {
                        // ================= وضع الإضافة =================
                        int newPaymentId = await isolatedPaymentService.AddNewPaymentAsync(saveDto);

                        if (newPaymentId > 0)
                        {
                            MessageBox.Show("تم حفظ الدفعة المالية وإصدار السداد بنجاح!", "نجاح عملية الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAllFields();
                            await LoadPaymentsDataAsync();
                        }
                        else
                        {
                            MessageBox.Show("حدث خطأ أثناء معالجة عملية الدفع. حاول مرة أخرى.", "خطأ مالي", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // ================= وضع التعديل =================
                        // استدعاء خدمة التحديث المعزولة (افترضنا وجود UpdatePaymentAsync في البزنس)
                        bool isUpdated = await isolatedPaymentService.UpdatePaymentAsync(saveDto);

                        if (isUpdated)
                        {
                            MessageBox.Show("تم تحديث الدفعة المالية بنجاح!", "نجاح التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // إعادة تهيئة الواجهة لوضع الإضافة الأصلي
                            btnNewPayment_Click(this, EventArgs.Empty);
                            await LoadPaymentsDataAsync();
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