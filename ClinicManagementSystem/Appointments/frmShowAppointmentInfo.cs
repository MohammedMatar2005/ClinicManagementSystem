using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness.Services;
using ClinicBusiness.DTO.AppointmentsDTOs;
using ClinicDataAccess.Data;
using ClinicDataAccess.Repositories;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmShowAppointmentInfo : Form
    {

        private int _appointmentId;
        private readonly clsAppointment _appointmentService;


        public frmShowAppointmentInfo(int apppointmentId)
        {
            InitializeComponent();
            _appointmentId = apppointmentId;

            var context = new ClinicManagementSystemContext();
            var repo = new AppointmentRepository(context);
            _appointmentService = new clsAppointment(repo);
        }

        private async void _FillData()
        {
            // جلب البيانات بانتظار الخدمة غير المتزامنة
            var appointment = await _appointmentService.GetAppointmentByIdAsync(_appointmentId);

            // التحقق من أن الكائن ليس فارغاً لمنع توقف البرنامج فجأة
            if (appointment == null)
            {
                MessageBox.Show("عذراً، لم يتم العثور على بيانات هذا الموعد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // ── سطر 1: رقم الموعد + تاريخ الإنشاء ──
            txtAppointmentId.Text = appointment.AppointmentId.ToString();
            txtCreatedDate.Text = appointment.CreatedDate.ToString("yyyy-MM-dd HH:mm");

            // ── سطر 2: اسم المريض + تاريخ آخر تحديث ──
            txtPatientName.Text = appointment.PatientFullName ?? "غير محدد";
            txtUpdatedDate.Text = appointment.UpdatedDate.ToString("yyyy-MM-dd HH:mm");

            // ── سطر 3: اسم الطبيب + حالة الموعد ──
            txtDoctorName.Text = appointment.DoctorFullName ?? "غير محدد";
            txtStatusName.Text = appointment.StatusName ?? "غير محدد";

            // ── سطر 4: تاريخ الموعد + الحالة في النظام ──
            txtAppointmentDate.Text = appointment.AppointmentDate.ToString("yyyy-MM-dd HH:mm");
            chkIsActive.Checked = appointment.IsActive;

            // ── سطر 5: سبب الزيارة (نص متعدد الأسطر) ──
            txtReasonForVisit.Text = appointment.ReasonForVisit ?? string.Empty;

            // ── سطر 6: ملاحظات (نص متعدد الأسطر) ──
            txtNotes.Text = appointment.Notes ?? string.Empty;
        }

        private void _LoadAppointmentInfo()
        {
            if (_appointmentId <= 0)
            {
                MessageBox.Show("معرف خاطئ.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillData();
        }

        private void frmShowAppointmentInfo_Load(object sender, EventArgs e)
        {
            _LoadAppointmentInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
