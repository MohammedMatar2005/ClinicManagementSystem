using ClinicBusiness.DTO.AppointmentsDTOs;
using ClinicBusiness.Models;
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
        private readonly clsLoggingService _loggingService;

        private int _selectedPatientId = -1;
        private int _selectedDoctorId = -1;

        public frmAppointments()
        {
            InitializeComponent();

            var context = new ClinicManagementSystemContext();
            _appointmentService = new clsAppointment(context);
            _loggingService = new clsLoggingService(context);
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
            dtpAppointmentDate.Value = DateTime.Now;

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
                List<AppointmentViewDTO> appointmentsList = await _appointmentService.GetAllAppointmentsAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("AppointmentId", typeof(int));
                dt.Columns.Add("PatientFullName", typeof(string));
                dt.Columns.Add("PatientNationalNumber", typeof(string));
                dt.Columns.Add("DoctorFullName", typeof(string));
                dt.Columns.Add("AppointmentDate", typeof(DateTime));
                dt.Columns.Add("StatusTitle", typeof(string));

                if (appointmentsList != null)
                {
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
                }

                // 1. الاحتفاظ بشرط الفلترة الحالي (في حال كان المستخدم يبحث في شريط البحث)
                string currentFilter = _appointmentsDataView?.RowFilter ?? string.Empty;

                // 2. إنشائ كائن DataView جديد من البيانات المحدثة
                _appointmentsDataView = dt.DefaultView;
                _appointmentsDataView.RowFilter = currentFilter;

                // 3. قطع الربط القديم أولاً ثم إعادتها لإجبار DataGridView على إعادة بناء الصفوف
                dgvAppointments.DataSource = null;
                dgvAppointments.DataSource = _appointmentsDataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب المواعيد: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await _loggingService.LogAsync($"خطأ جلب المواعيد: {ex.Message}", (enLogSeverity)2);
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

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            txtReason.Clear();
            txtNotes.Clear();
            txtPatinetId.Clear();
            txtDoctorId.Clear();

            dtpAppointmentDate.Value = DateTime.Now;

            _selectedPatientId = -1;
            _selectedDoctorId = -1;
        }

        private async void DeleteAppointmentMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0) return;

            int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["colAppointmentId"].Value);
            if (appointmentId <= 0) return;

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

            int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["colAppointmentId"].Value);
            if (appointmentId <= 0) return;

            using (var showInfoForm = new frmShowAppointmentInfo(appointmentId))
            {
                showInfoForm.ShowDialog();
            }
        }

        private void btnChoosePatient_Click(object sender, EventArgs e)
        {
            using (frmChoosePatient frm = new frmChoosePatient())
            {
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedPatientId = frm.PatientId;
                    txtPatinetId.Text = _selectedPatientId.ToString();
                }
            }
        }

        private void btnChooseDoctor_Click(object sender, EventArgs e)
        {

            

            using (frmChooseDoctor frm = new frmChooseDoctor())
            {

                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedDoctorId = frm.DoctorId;
                    txtDoctorId.Text = _selectedDoctorId.ToString();
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // مزامنة المعرفات في حال ألقى المستخدم قيمة يدوية في الـ TextBox
            if (int.TryParse(txtPatinetId.Text.Trim(), out int pId)) _selectedPatientId = pId;
            if (int.TryParse(txtDoctorId.Text.Trim(), out int dId)) _selectedDoctorId = dId;

            if (_selectedPatientId <= 0)
            {
                MessageBox.Show("الرجاء اختيار مريض للموعد أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatinetId.Focus();
                return;
            }

            if (_selectedDoctorId <= 0)
            {
                MessageBox.Show("الرجاء اختيار طبيب للموعد أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDoctorId.Focus();
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

            var appointment = new AppointmentSaveDto
            {
                AppointmentDate = dtpAppointmentDate.Value,
                DoctorId = _selectedDoctorId,
                PatientId = _selectedPatientId,
                AppointmentStatusId = cmbStatus.SelectedIndex + 1,
                Notes = txtNotes.Text.Trim(),
                ReasonForVisit = txtReason.Text.Trim()
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

        private void AddNewAppointmentMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private async void UpdateAppointmentMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0) return;

            int selectedAppointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["colAppointmentId"].Value);
            if (selectedAppointmentId <= 0) return;

            using (frmUpdateAppointment frm = new frmUpdateAppointment(selectedAppointmentId))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // إعادة تحميل الجدول فور إغلاق شاشة التعديل بنجاح
                    await LoadAppointmentsDataAsync();
                }
            }
        }
    }
}