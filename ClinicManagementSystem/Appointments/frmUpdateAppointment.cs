using ClinicBusiness;
using ClinicBusiness.DTO.AppointmentsDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmUpdateAppointment : Form
    {
        private int _selectedAppointmentId;
        private clsAppointment _appointmentService;
        private int _selectedPatientId;
        private int _selectedDoctorId;

        public enum enAppointmentStatus
        {
            Pending = 1,
            Confirmed = 2,
            Suspended = 3,
            Cancelled = 4
        }

        public frmUpdateAppointment(int selectedAppointmentId)
        {
            InitializeComponent();
            _selectedAppointmentId = selectedAppointmentId;

            var context = new ClinicManagementSystemContext();
            _appointmentService = new clsAppointment(context);
        }

        private void _LoadAppointmentStatusesInComboBox()
        {
            var statusList = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, "انتظار"),
                new KeyValuePair<int, string>(2, "مؤكد"),
                new KeyValuePair<int, string>(3, "معلق"),
                new KeyValuePair<int, string>(4, "ملغي")
            };

            cmbAppointmentStatus.DataSource = statusList;
            cmbAppointmentStatus.ValueMember = "Key";
            cmbAppointmentStatus.DisplayMember = "Value";

        }

        private async void frmUpdateAppointment_Load(object sender, EventArgs e)
        {
            _LoadAppointmentStatusesInComboBox();
            await _LoadAppointmentData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task _LoadAppointmentData()
        {
            try
            {
                // جلب بيانات الموعد من السيرفس بواسطة الـ ID
                var appointment = await _appointmentService.GetAppointmentByIdAsync(_selectedAppointmentId);

                if (appointment == null)
                {
                    MessageBox.Show("لم يتم العثور على بيانات الموعد المحدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // 1. تخزين المعرفات المطلوبة للتحقق لاحقاً عند الحفظ
                _selectedPatientId = appointment.PatientId;
                _selectedDoctorId = appointment.DoctorId;

                txtAppointmentId.Text = appointment.AppointmentId.ToString();

                txtDoctorName.Text = appointment.DoctorFullName;
                txtPatientName.Text = appointment.PatientFullName;

                txtCreatedDate.Text = appointment.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss");
                txtUpdatedDate.Text = appointment.UpdatedDate.ToString("yyyy-MM-dd HH:mm:ss") ?? "لم يتم التحديث بعد";

                cmbAppointmentStatus.SelectedValue = appointment.StatusName;

                // 2. تعبئة عناصر الواجهة بالبيانات الحالية
                dtpAppointmentDate.Value = appointment.AppointmentDate;
                txtReasonForVisit.Text = appointment.ReasonForVisit;
                txtNotes.Text = appointment.Notes;
                chkIsActive.Checked = appointment.IsActive;
                cmbAppointmentStatus.SelectedValue = appointment.AppointmentStatusId;

                // (اختياري) إذا كان لديك تكست بوكس يعرض اسم المريض أو الطبيب للقراءة فقط:
                // lblPatientName.Text = appointment.PatientName;
                // lblDoctorName.Text = appointment.DoctorName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الموعد: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateOnly sourceDate = DateOnly.FromDateTime(dtpAppointmentDate.Value);
                DateTime appointmentDateTime = sourceDate.ToDateTime(TimeOnly.MinValue);

                if (appointmentDateTime < DateTime.Today)
                {
                    MessageBox.Show("تاريخ الموعد يجب أن يكون اليوم أو في المستقبل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var AppointmentSaveDto = new AppointmentSaveDto
                {
                    AppointmentId = _selectedAppointmentId,
                    PatientId = _selectedPatientId, // 👈 يجب جلبهم وتخزينهم في متغيرات على مستوى الكلاس كـ Fields عند تحميل بيانات الموعد أول مرة
                    DoctorId = _selectedDoctorId,   // 👈 وتعبئتهم هنا لكي تنجح عمليات التحقق بالأسفل
                    ReasonForVisit = txtReasonForVisit.Text,
                    Notes = txtNotes.Text,
                    IsActive = chkIsActive.Checked,
                    AppointmentDate = appointmentDateTime,
                    AppointmentStatusId = (int)cmbAppointmentStatus.SelectedValue
                };

                if (!await _appointmentService.IsAppointmentCancelled(AppointmentSaveDto.PatientId))
                {
                    MessageBox.Show("الموعد المحدد ملغى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!await _appointmentService.IsPatientAvailableAsync(AppointmentSaveDto.PatientId, AppointmentSaveDto.AppointmentDate, _selectedAppointmentId))
                {
                    MessageBox.Show("المريض غير متوفر في تاريخ الموعد المحدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!await _appointmentService.IsDoctorAvailableAsync(AppointmentSaveDto.DoctorId, AppointmentSaveDto.AppointmentDate, _selectedAppointmentId))
                {
                    MessageBox.Show("الطبيب غير متوفر في تاريخ الموعد المحدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _appointmentService.UpdateAppointmentAsync(AppointmentSaveDto);

                if (result)
                {
                    MessageBox.Show("تم تعديل الموعد بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء تعديل الموعد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ غير متوقع: {ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}