using ClinicBusiness.DTO.AppointmentsDTOs;
using ClinicBusiness.Services;
using ClinicDataAccess.Data;
using ClinicDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmAppointments : Form
    {
        // تم نقل الـ Context ليتم إدارته بشكل سليم، أو يمكنك الاعتماد على OnConfiguring داخله
        private readonly ClinicManagementSystemContext _context;
        private readonly clsAppointment _appointmentService;

        public frmAppointments()
        {
            InitializeComponent();

            _context = new ClinicManagementSystemContext();
            var repo = new AppointmentRepository(_context);
            _appointmentService = new clsAppointment(repo);

            ConfigureGridMapping();
        }

        // 1. قمنا بتحويل الحدث إلى async ليدعم الانتظار غير المتزامن
        private async void frmAppointments_Load(object sender, EventArgs e)
        {
            // ننتظر تحميل البيانات دون أن تتجمد الواجهة
            await LoadAppointmentsDataAsync();
        }

        private void ConfigureGridMapping()
        {
            colAppointmentId.DataPropertyName = "AppointmentId";
            colPatientName.DataPropertyName = "PatientFullName";
            colDoctorName.DataPropertyName = "DoctorFullName";
            colAppointmentDate.DataPropertyName = "AppointmentDate";
            colStatusName.DataPropertyName = "StatusTitle";

            dgvAppointments.AutoGenerateColumns = false;
        }

        // 2. تحويل الدالة إلى دالة غير متزامنة احترافية تُرجع Task
        private async Task LoadAppointmentsDataAsync()
        {
            try
            {
                // استخدام await هنا يحل مشكلة الـ Deadlock تماماً ويجعل الفورم يفتح فوراً
                List<AppointmentViewDTO> appointments = await _appointmentService.GetAllAppointmentsAsync();

                // ربط القائمة بالـ GridView بأمان
                dgvAppointments.DataSource = appointments;
            }
            catch (Exception ex)
            {
                // إذا كان هناك خطأ في الـ Connection String أو الـ DbContext سيظهر لك هنا بوضوح
                MessageBox.Show($"حدث خطأ أثناء جلب المواعيد: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}