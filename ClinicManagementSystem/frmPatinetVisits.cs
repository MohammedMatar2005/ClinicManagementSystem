using ClinicBusiness.DTO.PatientVisitsDTOs;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmPatinetVisits : Form
    {
        private int _selectedAppointmentId;
        private int _selectedDoctorId;

        // تعريف الخدمة المحقونة
        private readonly clsPatientVisit _patientVisitService;

        // استخدام الـ BindingSource كوسيط ذكي لعرض البيانات وفلترتها بدلاً من DataTable
        private BindingSource _visitsBindingSource = new BindingSource();

        // تحديث الباني ليستقبل الخدمة مباشرة بناءً على المعمارية الجديدة
        public frmPatinetVisits(clsPatientVisit patientVisitService)
        {
            InitializeComponent();

            _patientVisitService = patientVisitService ?? throw new ArgumentNullException(nameof(patientVisitService));

            // إجبار الحاوية الرئيسية على الملء وإعادة الترتيب تلقائياً عند التشغيل
            pnlMainBackground.Dock = DockStyle.Fill;
            tabControlVisits.Dock = DockStyle.Fill;

            // إجبار الـ TableLayout الكبيرة على التمدد الكامل داخل التبويب
            tlpNewVisitMain.Dock = DockStyle.Fill;
            tlpHistoryMain.Dock = DockStyle.Fill;

            lblBloodPressure.BringToFront();
            lblTemperature.BringToFront();
            lblHeartRate.BringToFront();
            lblWeight.BringToFront();
            lblHeight.BringToFront();

            // تنشيط التحديث البصري
            this.Refresh();
        }

        private async void frmPatinetVisits_Load(object sender, EventArgs e)
        {
            ConfigureGridMapping();
            await _LoadAllVisits();
        }

        private void ConfigureGridMapping()
        {
            // 1. إيقاف التوليد التلقائي للأعمدة
            dgvVisitsHistory.AutoGenerateColumns = false;

            // 2. الربط مباشرة باستخدام الترتيب (Index) للأعمدة كما هي مضافة في الجريد لديك
            // تأكد من ترتيب الأعمدة من اليسار إلى اليمين (0 هو العمود الأول، 1 هو الثاني... وهكذا)
            if (dgvVisitsHistory.Columns.Count >= 7)
            {
                dgvVisitsHistory.Columns[0].DataPropertyName = "VisitId";
                dgvVisitsHistory.Columns[1].DataPropertyName = "PatientFullName";
                dgvVisitsHistory.Columns[2].DataPropertyName = "DoctorFullName";
                dgvVisitsHistory.Columns[3].DataPropertyName = "VisitDate";
                dgvVisitsHistory.Columns[4].DataPropertyName = "AppointmentReason";
                dgvVisitsHistory.Columns[5].DataPropertyName = "Diagnosis";
                dgvVisitsHistory.Columns[6].DataPropertyName = "VisitStatusTitle";
            }
        }

        private async Task _LoadAllVisits()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // 1. جلب قائمة الزيارات مباشرة من الـ Business Layer كـ List من الـ DTOs
                List<PatientVisitViewDTO> visitsList = await _patientVisitService.GetAllPatientVisitsAsync();

                // 2. ربط القائمة بالـ BindingSource
                _visitsBindingSource.DataSource = visitsList;

                // 3. إسناد الـ BindingSource للـ DataGridView مباشرة دون الحاجة لـ DataTable يدوياً
                dgvVisitsHistory.DataSource = _visitsBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب الزيارات من السيرفر: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnChooseAppointment_Click(object sender, EventArgs e)
        {
            using (frmChooseAppointment frm = new frmChooseAppointment())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedAppointmentId = frm.AppointmentId;
                    txtAppointmentId.Text = _selectedAppointmentId.ToString();
                }
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearControls(this);
        }

        private void ClearControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.Clear();
                }
                else if (c is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
                else if (c is CheckBox chk)
                {
                    chk.Checked = false;
                }
                else if (c is RadioButton rdb)
                {
                    rdb.Checked = false;
                }

                if (c.HasChildren)
                {
                    ClearControls(c);
                }
            }
        }

        private void tlpColumnsContainer_Paint(object sender, PaintEventArgs e)
        {
            // اتركها فارغة إذا لم تكن تستخدمها أو احذفها من ملف الـ Designer
        }
    }
}