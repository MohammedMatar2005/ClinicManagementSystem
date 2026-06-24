using ClinicBusiness.DTO.AppointmentsDTOs;
using ClinicBusiness.Models; // تم استبدال الداتا أكسيس بالموديلز الموحدة للبزنس
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmAppointments : Form
    {
        
        private readonly clsAppointment _appointmentService;
        private DataView _appointmentsDataView = new DataView();

        private int _selectedPatientId = -1;
        private int _selectedDoctorId = -1; // تم تعديل القيمة الابتدائية لـ -1 للحماية

        public frmAppointments()
        {
            InitializeComponent();

            // حقن الـ DbContext مباشرة في السيرفس وإلغاء طبقة الـ Repository تماماً
            var context = new ClinicManagementSystemContext();
            _appointmentService = new clsAppointment(context);
        }

        private async void frmAppointments_Load(object sender, EventArgs e)
        {
            ConfigureGridMapping();

            cmbSearchType.Items.Clear();
            cmbSearchType.Items.Add("المعرف");
            cmbSearchType.Items.Add("الرقم الوطني");
            cmbSearchType.SelectedIndex = 0;

            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.CustomFormat = "yyyy/MM/dd   hh:mm tt";
            dtpAppointmentDate.ShowUpDown = false;

            await LoadAppointmentsDataAsync();
        }

        private void ConfigureGridMapping()
        {
            dgvAppointments.AutoGenerateColumns = false;

            colAppointmentId.DataPropertyName = "AppointmentId";
            colPatientName.DataPropertyName = "PatientFullName";
            PatientNationalNumber.DataPropertyName = "PatientNationalNumber";
            colDoctorName.DataPropertyName = "DoctorFullName";
            colAppointmentDate.DataPropertyName = "AppointmentDate";
            colStatusName.DataPropertyName = "StatusTitle";
        }

        private async Task LoadAppointmentsDataAsync()
        {
            try
            {
                // 1. جلب القائمة مباشرة من السيرفس التي تتعامل مع الـ DbContext
                List<AppointmentViewDTO> appointmentsList = await _appointmentService.GetAllAppointmentsAsync();

                // 2. بناء الـ DataTable لعمل الفلترة السريعة في الذاكرة
                DataTable dt = new DataTable();
                dt.Columns.Add("AppointmentId", typeof(int));
                dt.Columns.Add("PatientFullName", typeof(string));
                dt.Columns.Add("PatientNationalNumber", typeof(string));
                dt.Columns.Add("DoctorFullName", typeof(string));
                dt.Columns.Add("AppointmentDate", typeof(DateTime));
                dt.Columns.Add("StatusTitle", typeof(string));

                foreach (var item in appointmentsList)
                {
                    dt.Rows.Add(
                        item.AppointmentId,
                        item.PatientFullName,
                        item.PatientNationalNumber,
                        item.DoctorFullName,
                        item.AppointmentDate,
                        item.StatusTitle
                    );
                }

                _appointmentsDataView = dt.DefaultView;
                dgvAppointments.DataSource = _appointmentsDataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب المواعيد: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchValue.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(searchValue))
            {
                _appointmentsDataView.RowFilter = string.Empty;
                return;
            }

            try
            {
                if (cmbSearchType.SelectedIndex == 0)
                {
                    if (int.TryParse(searchValue, out int id))
                    {
                        _appointmentsDataView.RowFilter = $"AppointmentId = {id}";
                    }
                    else
                    {
                        _appointmentsDataView.RowFilter = "1 = 0";
                    }
                }
                else if (cmbSearchType.SelectedIndex == 1)
                {
                    _appointmentsDataView.RowFilter = $"PatientNationalNumber LIKE '%{searchValue}%'";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"خطأ أثناء الفلترة اللحظية: {ex.Message}");
            }
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ClearAllFields()
        {
            txtSearchValue.Clear();
            cmbSearchType.SelectedIndex = 0;
            _appointmentsDataView.RowFilter = string.Empty;
            cmbStatus.SelectedIndex = 0;
            txtReason.Clear();
            txtNotes.Clear();
            txtPatinetId.Clear();
            txtDoctorId.Clear();
            _selectedPatientId = -1;
            _selectedDoctorId = -1;
        }

        private async void DeleteAppointmentMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0) return;

            int appointmentId = (int)dgvAppointments.SelectedRows[0].Cells["colAppointmentId"].Value;
            if (appointmentId == 0) return;

            DialogResult result = MessageBox.Show(
                $"هل أنت متأكد من رغبتك في حذف الموعد رقم ({appointmentId}) بشكل نهائي؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = await _appointmentService.DeleteAppointmentAsync(appointmentId);

                if (isDeleted)
                {
                    MessageBox.Show("تم حذف الموعد بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadAppointmentsDataAsync();
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء حذف الموعد. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ShowInfoMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0) return;

            int appointmentId = (int)dgvAppointments.SelectedRows[0].Cells["colAppointmentId"].Value;
            if (appointmentId == 0) return;

            var showInfoForm = new frmShowAppointmentInfo(appointmentId);
            showInfoForm.ShowDialog();
        }

        private void btnChoosePatient_Click(object sender, EventArgs e)
        {
            using (frmChoosePatient frm = new frmChoosePatient())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedPatientId = frm.PatientId;
                    txtPatinetId.Text = _selectedPatientId.ToString();
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedPatientId == -1)
            {
                MessageBox.Show("الرجاء اختيار مريض للموعد أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedDoctorId == -1)
            {
                MessageBox.Show("الرجاء اختيار طبيب للموعد أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // فحص التضارب المباشر عبر السيرفس
            if (await _appointmentService.IsPatientAvailableAsync(_selectedPatientId, dtpAppointmentDate.Value) == false)
            {
                MessageBox.Show("المريض لديه موعد آخر في نفس الوقت. الرجاء اختيار وقت آخر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (await _appointmentService.IsDoctorAvailableAsync(_selectedDoctorId, dtpAppointmentDate.Value) == false)
            {
                MessageBox.Show("الطبيب لديه موعد آخر في نفس الوقت. الرجاء اختيار وقت آخر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // الاعتماد على الـ DTO الموحد للتخزين
            var appointment = new AppointmentSaveDto
            {
                AppointmentDate = dtpAppointmentDate.Value,
                DoctorId = _selectedDoctorId,
                PatientId = _selectedPatientId,
                AppointmentStatusId = cmbStatus.SelectedIndex + 1,
                Notes = txtNotes.Text.Trim()
            };

            int newAppointmentId = await _appointmentService.AddNewAppointmentAsync(appointment);

            if (newAppointmentId > 0)
            {
                MessageBox.Show("تم حفظ الموعد بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllFields();
                await LoadAppointmentsDataAsync();
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء حفظ الموعد. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseDoctor_Click(object sender, EventArgs e)
        {
            using (frmChooseDoctor frm = new frmChooseDoctor())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedDoctorId = frm.DoctorId;
                    txtDoctorId.Text = _selectedDoctorId.ToString();
                }
            }
        }

        private void AddNewAppointmentMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
    }
}