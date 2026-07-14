using ClinicBusiness.DTO.DoctorsDTOs;
using ClinicBusiness.DTO.UsersDTOs;
using ClinicBusiness.Models; // الاعتماد على الموديلز الموحدة للبزنس
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments; // تبعاً لمجلد شاشات المواعيد
using ClinicManagementSystem.Finance;
using ClinicManagementSystem.Invoices;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmMain : Form
    {
        // 1. تعريف المستخدم الحالي والـ Context على مستوى الكلاس

        private readonly UserViewDTO _loggedUser;

        private readonly ClinicManagementSystemContext _context;
        private readonly clsPayment _paymentService;
        private readonly clsAppointment _appointmentService;

        private readonly clsInvoice _invoiceService;
        private readonly clsPatientVisit _patientVisitService;
        private readonly clsPatient _patientService;
        private readonly clsUser _userService;
        private readonly clsDoctor _doctorService;
        private readonly clsClinicSettings _settingsService;

        // 2. إجبار المَشيد (Constructor) على استقبال بيانات المستخدم المختار عند اللوجن
        public frmMain(UserViewDTO loggedUser)
        {
            InitializeComponent();

            _loggedUser = loggedUser;

            // حقن الـ Context مباشرة وإلغاء الـ Repositories
            _context = new ClinicManagementSystemContext();
            _paymentService = new clsPayment(_context);
            _invoiceService = new clsInvoice(_context);
            _patientVisitService = new clsPatientVisit(_context);
            _appointmentService = new clsAppointment(_context);
            _patientService = new clsPatient(_context);
            _userService = new clsUser(_context);
            _doctorService = new clsDoctor(_context);
            _settingsService = new clsClinicSettings(_context);
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            // عرض اسم المستخدم الحالي في الواجهة (مثلاً في ليبل الترحيب)
            lblWelcomeTitle.Text = $"مرحباً بك: {_loggedUser.FullName}";

            lblBrandingIcon.Text = await _settingsService.GetClinicName();

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

                var todayAppointments = await _appointmentService.GetTodaysAppointmentsCountAsync();
                lblValueAppointments.Text = todayAppointments.ToString();

                var todayPatients = await _patientService.GetTodaysPatientsCountAsync();
                lblValuePatients.Text = todayPatients.ToString();

                lblUserName.Text = _loggedUser.Username;
            }
            catch (Exception ex)
            {
                lblValueRevenue.Text = "0.00";
                // يمكنك تسجيل الخطأ هنا بدون تعطيل الشاشة الرئيسية
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Form frm = new frmChoosePatient();
            frm.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Form frm = new frmChooseAppointment();
            frm.ShowDialog();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Form frm = new frmChooseDoctor();
            frm.ShowDialog();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("قريباً...", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {


            Form frm = new frmChooseInvoice();
            frm.ShowDialog();
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

        private void btnPayments_Click(object sender, EventArgs e)
        {
            using (Form frm = new frmPayments(_paymentService, _invoiceService))
            {
                frm.ShowDialog();
            }
        }

        private async void toolStripShowInfo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            toolStripShowInfo.Enabled = false;

            try
            {
                UserDetailsDTO? userInfo = null;
                DoctorViewDTO? doctorInfo = null;

                // 2. استخدام Context معزول لمنع أي تصادم مع استعلامات الـ Grid أو الفورم الرئيسية
                using (var freshContext = new ClinicManagementSystemContext())
                {
                    var isolatedUserService = new clsUser(freshContext);
                    var isolatedDoctorService = new clsDoctor(freshContext);

                    // جلب بيانات المستخدم أولاً
                    userInfo = await isolatedUserService.GetUserByUsernameAsync(_loggedUser.Username.Trim());

                    // 3. التحقق الآمن من وجود المستخدم قبل قراءة الـ UserId
                    if (userInfo == null)
                    {
                        MessageBox.Show("لم يتم العثور على معلومات حساب المستخدم الحالي في النظام.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // جلب بيانات الطبيب بناءً على الـ UserId المقترن به
                    doctorInfo = await isolatedDoctorService.GetDoctorByUserIdAsync(userInfo.UserId);
                }

                // 4. التحقق من وجود بيانات الطبيب
                if (doctorInfo == null)
                {
                    MessageBox.Show("هذا الحساب غير مسجل كطبيب في النظام لعرض بياناته العيادية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 5. عرض الفورم وتمرير بيانات الطبيب الكاملة (التي تحتوي أصلاً على بيانات الشخص والمستخدم المسطحة)
                using (frmShowDoctorInfo frm = new frmShowDoctorInfo(doctorInfo.DoctorId))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ غير متوقع أثناء تحميل ملف الطبيب:\n{ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 6. إعادة الواجهة لحالتها الطبيعية
                toolStripShowInfo.Enabled = true;
                this.Cursor = Cursors.Default;
            }

        }

        private void toolStripLogout_Click(object sender, EventArgs e)
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

        private void btnProfileMenu_Click(object sender, EventArgs e)
        {
            if (cmsOptions != null)
            {
                // 2. حساب الإحداثيات ليظهر المنيو أسفل الزر مباشرة بالتمام
                // Point.Empty تعني الزاوية العليا اليسرى للزر، وسنقوم بإزاحتها لأسفل بحسب ارتفاع الزر
                Point appearanceLocation = btnProfileMenu.PointToScreen(new Point(0, btnProfileMenu.Height));

                // 3. إظهار القائمة في الإحداثيات المحسوبة
                cmsOptions.Show(appearanceLocation);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (Form frm = new frmClinicSettings())
            {
                frm.ShowDialog();
            }
        }

        private void toolStripChangePassword_Click(object sender, EventArgs e)
        {
            using (Form frm = new frmChangePassword(_loggedUser, _userService))
            {
                frm.ShowDialog();
            }
        }

        private void lnkSystemLogs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            // هنا تقوم بفتح فورم الـ Logs وتمرير السيرفيس والمستخدم الحالي له
            //frmSystemLogs frm = new frmSystemLogs(_currentUser, _loggingService);
            //frm.ShowDialog(); // أو Show() حسب رغبتك في طريقة العرض
        
        }
    }
}