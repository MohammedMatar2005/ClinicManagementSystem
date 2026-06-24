using System;
using System.Windows.Forms;
using ClinicBusiness.Services;
using ClinicBusiness.Models; // الاعتماد على الموديلز الموحدة للبزنس

namespace ClinicManagementSystem.Appointments
{
    public partial class frmShowAppointmentInfo : Form
    {
        private readonly int _appointmentId;
        private readonly clsAppointment _appointmentService;

        public frmShowAppointmentInfo(int appointmentId)
        {
            InitializeComponent();
            _appointmentId = appointmentId;

            // حقن الـ Context مباشرة وإلغاء الـ Repository تماماً
            var context = new ClinicManagementSystemContext();
            _appointmentService = new clsAppointment(context);
        }

        private async void _FillData()
        {
            try
            {
                // جلب البيانات بانتظار الخدمة غير المتزامنة مباشرة
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
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل تفاصيل الموعد: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _LoadAppointmentInfo()
        {
            if (_appointmentId <= 0)
            {
                MessageBox.Show("معرف الموعد غير صحيح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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