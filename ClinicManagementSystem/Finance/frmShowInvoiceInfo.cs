using System;
using System.Windows.Forms;
using ClinicBusiness.Services;
using ClinicBusiness.Models;
using System.Threading.Tasks; // تأكد من وجود هذا النيمسبيدج للـ Task

namespace ClinicManagementSystem.Finance
{
    public partial class frmShowInvoiceInfo : Form
    {
        private readonly int _invoiceId;
        private readonly clsInvoice _invoiceService;
        private readonly clsPayment _paymentService;

        public frmShowInvoiceInfo(int invoiceId)
        {
            InitializeComponent();
            _invoiceId = invoiceId;

            var context = new ClinicManagementSystemContext();
            _invoiceService = new clsInvoice(context);
            _paymentService = new clsPayment(context);
        }

        // 1. تم تغيير العائد إلى Task ليصبح قابلاً للانتظار (Awaitable)
        private async Task _FillData()
        {
            try
            {
                // جلب بيانات الفاتورة
                var invoice = await _invoiceService.GetInvoiceByIdAsync(_invoiceId);

                if (invoice == null)
                {
                    MessageBox.Show("عذراً، لم يتم العثور على بيانات هذه الفاتورة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // ── سطر 1: رقم الفاتورة + رقم الزيارة المرتبطة ──
                txtInvoiceNumber.Text = invoice.InvoiceNumber ?? invoice.InvoiceId.ToString();
                txtVisitId.Text = invoice.VisitId.ToString();

                // ── حل خطأ الـ Null العضال باستخدام الـ Null-Conditional Operator ──
                var patientName = invoice.Visit?.Appointment?.Patient?.Person?.FullName;
                txtPatientName.Text = patientName ?? "غير محدد";
                txtInvoiceDate.Text = invoice.InvoiceDate.ToString("yyyy-MM-dd");

                // ── سطر 3: تاريخ الاستحقاق ──
                txtDueDate.Text = invoice.DueDate.ToString("yyyy-MM-dd");
                txtCreatedDate.Text = invoice.CreatedDate.ToString("yyyy-MM-dd HH:mm");

                // ── سطر 4: الرسوم المالية ──
                txtConsultationFee.Text = invoice.ConsultationFee.ToString("N2");
                txtLabTestFee.Text = invoice.LabTestFee.ToString("N2");
                txtProcedureFee.Text = invoice.ProcedureFee.ToString("N2");
                txtOtherCharges.Text = invoice.OtherCharges.ToString("N2");

                // ── سطر 6: الخصومات والضرائب ──
                txtDiscountPercentage.Text = (invoice.DiscountPercentage ?? 0).ToString("G");
                txtTaxPercentage.Text = (invoice.TaxPercentage ?? 0).ToString("G");

                // ── سطر 7: المجموع الفرعي وقيمة الخصم ──
                txtSubTotal.Text = (invoice.SubTotal ?? 0).ToString("N2");
                txtDiscountAmount.Text = (invoice.DiscountAmount ?? 0).ToString("N2");

                // ── سطر 8: الإجمالي النهائي والمبالغ المدفوعة ──
                decimal finalAmount = invoice.FinalAmount ?? 0;
                txtFinalTotal.Text = finalAmount.ToString("N2");

                // انتظار جلب المدفوعات بشكل سليم
                var totalPaid = await _paymentService.GetTotalPaymentsForInvoiceAsync(_invoiceId);
                txtPaidAmount.Text = totalPaid.ToString("N2");

                // الحساب المالي الدقيق بدون تعارض أنواع البيانات
                decimal remainingAmount = finalAmount - totalPaid;
                if (remainingAmount < 0) remainingAmount = 0;

                // ── سطر 9: المبلغ المتبقي وحالة الفاتورة ──
                txtRemainingAmount.Text = remainingAmount.ToString("N2");
                txtStatusName.Text = invoice.Status?.StatusName ?? "غير محدد";

                if (invoice.Status != null)
                {
                    _ApplyStatusColor(invoice.Status.StatusName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل تفاصيل الفاتورة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // تم تحديث هذه الدالة لتغيير لون الخلفية (BackColor) مع لون النص (ForeColor) معاً
        // بحيث يظهر حقل الحالة كشارة (Badge) ملونة متناسقة مع لوحة الألوان الدلالية
        // المعتمدة في بقية الفورم (نفس أسلوب: خلفية باستيل فاتحة + نص داكن مشبّع)
        private void _ApplyStatusColor(string statusName)
        {
            if (statusName == "غير مدفوعة")
            {
                // غير مدفوعة → أحمر باستيل (نفس نمط حقول الخصم والمتبقي)
                txtStatusName.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
                txtStatusName.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            }
            else if (statusName == "مدفوعة جزئياً")
            {
                // مدفوعة جزئياً → برتقالي/كهرماني باستيل (حالة وسطى تحذيرية)
                txtStatusName.BackColor = System.Drawing.Color.FromArgb(255, 247, 237);
                txtStatusName.ForeColor = System.Drawing.Color.FromArgb(234, 88, 12);
            }
            else if (statusName == "مدفوعة بالكامل")
            {
                // مدفوعة بالكامل → أخضر باستيل (نفس نمط الإجمالي النهائي/المدفوع)
                txtStatusName.BackColor = System.Drawing.Color.FromArgb(209, 250, 229);
                txtStatusName.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70);
            }
            else
            {
                // حالة افتراضية/غير معروفة → نفس لون الشارة النيلي الافتراضي في التصميم
                txtStatusName.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
                txtStatusName.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            }
        }

        // 2. تم تحويل الدالة لتعود بـ Task لتمرير الـ await للأعلى
        private async Task _LoadInvoiceInfo()
        {
            if (_invoiceId <= 0)
            {
                MessageBox.Show("معرف الفاتورة غير صحيح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // انتظار تعبئة البيانات الفعلي
            await _FillData();
        }

        // 3. جعل حدث التحميل async لتطبيق الـ await بشكل نهائي ومستقر
        private async void frmShowInvoiceInfo_Load(object sender, EventArgs e)
        {
            await _LoadInvoiceInfo();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}