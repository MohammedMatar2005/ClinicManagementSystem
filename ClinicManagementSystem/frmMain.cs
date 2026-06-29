using System;
using System.Windows.Forms;
using ClinicBusiness.Services;
using ClinicBusiness.Models; // الاعتماد على الموديلز الموحدة للبزنس
using ClinicManagementSystem.Appointments; // تبعاً لمجلد شاشات المواعيد
using System.Threading.Tasks;
using ClinicBusiness.DTO.UsersDTOs;

namespace ClinicManagementSystem
{
    public partial class frmMain : Form
    {
        // 1. تعريف المستخدم الحالي والـ Context على مستوى الكلاس
        private readonly UserViewDTO _currentUser;
        private readonly ClinicManagementSystemContext _context;
        private readonly clsPayment _paymentService;

        private readonly clsInvoice _invoiceService;
        private readonly clsPatientVisit _patientVisitService;

        // 2. إجبار المَشيد (Constructor) على استقبال بيانات المستخدم المختار عند اللوجن
        public frmMain(UserViewDTO loggedInUser)
        {
            InitializeComponent();

            _currentUser = loggedInUser;

            // حقن الـ Context مباشرة وإلغاء الـ Repositories
            _context = new ClinicManagementSystemContext();
            _paymentService = new clsPayment(_context);
            _invoiceService = new clsInvoice(_context);
            _patientVisitService = new clsPatientVisit(_context);
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            // عرض اسم المستخدم الحالي في الواجهة (مثلاً في ليبل الترحيب)
            lblWelcomeTitle.Text = $"مرحباً بك: {_currentUser.Username}";

            // جلب وعرض إيرادات اليوم بناءً على السيرفس المحدثة
            await _LoadTodayRevenue();
        }

        private async Task _LoadTodayRevenue()
        {
            try
            {
                // جلب القيم بشكل غير متزامن متوافق مع نمط الـ Async المعمول به
                var todayPayments = await _paymentService.GetPaymentAmountsTodayAsync();
                lblValueRevenue.Text = todayPayments.ToString("C2"); // تنسيق كعملة ماليّة
            }
            catch (Exception ex)
            {
                lblValueRevenue.Text = "0.00";
                // يمكنك تسجيل الخطأ هنا بدون تعطيل الشاشة الرئيسية
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
             Form frm = new frmPatients();
             frm.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Form frm = new frmAppointments();
            frm.ShowDialog();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateDoctor();
            frm.ShowDialog();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("قريباً...", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
             Form frm = new frmInvoices(_invoiceService, _patientVisitService);
             frm.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            // سيتم ربطها لاحقاً
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            Form frm = new frmSupport();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "هل أنت متأكد من الخروج من النظام؟",
                "تأكيد الإغلاق",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pagesContainer_Paint(object sender, PaintEventArgs e)
        {
            // للتصميم والرسم إن وجد
        }
    }
}