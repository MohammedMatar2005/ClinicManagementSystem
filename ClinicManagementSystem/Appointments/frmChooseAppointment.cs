using ClinicBusiness.DTO.AppointmentsDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicBusiness.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChooseAppointment : Form
    {
        private BindingSource _appointmentsBindingSource = new BindingSource();
        private clsAppointment _appointmentService;
        private readonly ClinicManagementSystemContext _context;

        public int AppointmentId { get; private set; }
        public string PatientName { get; private set; }

        public frmChooseAppointment()
        {
            InitializeComponent();
            _context = new ClinicManagementSystemContext();
            _appointmentService = new clsAppointment(_context);
        }

        private async void frmChooseAppointment_Load(object sender, EventArgs e)
        {
            _ConfigureDataGridView();
            cmbSearchType.SelectedIndex = 0; // الخيار الافتراضي: "بلا"
            await _LoadAllAppointmentsAsync();
        }

        private void _ConfigureDataGridView()
        {
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.Columns.Clear();

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AppointmentId",
                HeaderText = "رقم الموعد",
                DataPropertyName = "AppointmentId"
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PatientFullName",
                HeaderText = "اسم المريض",
                DataPropertyName = "PatientFullName"
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PatientNationalNumber",
                HeaderText = "الرقم الوطني",
                DataPropertyName = "PatientNationalNumber"
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DoctorFullName",
                HeaderText = "الطبيب المعالج",
                DataPropertyName = "DoctorFullName"
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AppointmentDate",
                HeaderText = "تاريخ ووقت الموعد",
                DataPropertyName = "AppointmentDate"
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StatusTitle",
                HeaderText = "حالة الموعد",
                DataPropertyName = "StatusTitle"
            });

            dgvAppointments.Columns["AppointmentId"].Width = 90;
            dgvAppointments.Columns["PatientNationalNumber"].Width = 110;
            dgvAppointments.Columns["StatusTitle"].Width = 100;
        }

        private async Task _LoadAllAppointmentsAsync()
        {
            try
            {
                List<AppointmentViewDTO> appointmentsList = await _appointmentService.GetAllAppointmentsAsync();

                if (appointmentsList != null)
                {
                    DataTable dtAppointments = ConvertToDataTable._ConvertToDataTable(appointmentsList);
                    _appointmentsBindingSource.DataSource = dtAppointments;
                    dgvAppointments.DataSource = _appointmentsBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات المواعيد: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllFields()
        {
            txtSearch.Text = string.Empty;
            _appointmentsBindingSource.RemoveFilter();
        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllFields();

            if (cmbSearchType.Text == "بلا")
            {
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;
                txtSearch.Focus();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام وفتاح التحكم (Backspace) فقط عند اختيار "رقم الموعد"
            if (cmbSearchType.Text == "رقم الموعد")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_appointmentsBindingSource.DataSource == null) return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(searchValue) || cmbSearchType.Text == "بلا")
            {
                _appointmentsBindingSource.RemoveFilter();
                return;
            }

            switch (cmbSearchType.Text)
            {
                case "رقم الموعد":
                    if (int.TryParse(searchValue, out int id))
                    {
                        _appointmentsBindingSource.Filter = $"AppointmentId = {id}";
                    }
                    else
                    {
                        _appointmentsBindingSource.RemoveFilter();
                    }
                    break;

                case "الرقم الوطني":
                    _appointmentsBindingSource.Filter = $"PatientNationalNumber LIKE '%{searchValue}%'";
                    break;

                case "اسم المريض":
                    _appointmentsBindingSource.Filter = $"PatientFullName LIKE '%{searchValue}%'";
                    break;

                case "الطبيب المعالج":
                    _appointmentsBindingSource.Filter = $"DoctorFullName LIKE '%{searchValue}%'";
                    break;

                case "حالة الموعد":
                    _appointmentsBindingSource.Filter = $"StatusTitle LIKE '%{searchValue}%'";
                    break;

                default:
                    _appointmentsBindingSource.RemoveFilter();
                    break;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _SelectAndClose();
        }

        private void dgvAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _SelectAndClose();
            }
        }

        private void _SelectAndClose()
        {
            if (_appointmentsBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)_appointmentsBindingSource.Current;

                AppointmentId = Convert.ToInt32(currentRow["AppointmentId"]);
                PatientName = Convert.ToString(currentRow["PatientFullName"]);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار موعد من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            using (frmAppointments frm = new frmAppointments())
            {
                frm.ShowDialog();
                await _LoadAllAppointmentsAsync();
            }
        }

        private void toolStripShowAppointmentInfo_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;

            int selectedAppointmentId = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["AppointmentId"].Value);

            using (frmShowAppointmentInfo frm = new frmShowAppointmentInfo(selectedAppointmentId))
            {
                frm.ShowDialog();
            }
        }

        private async void toolStripUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;

            int selectedAppointmentId = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["AppointmentId"].Value);

            using (frmUpdateAppointment frm = new frmUpdateAppointment(selectedAppointmentId))
            {
                frm.ShowDialog();
                await _LoadAllAppointmentsAsync();
            }
        }

        private async void toolStripAddNewAppointment_Click(object sender, EventArgs e)
        {
            using (frmAppointments frm = new frmAppointments())
            {
                frm.ShowDialog();
                await _LoadAllAppointmentsAsync();
            }
        }

        private async void toolStripDeleteAppointmen_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0) return;

            int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value);
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
                    await _LoadAllAppointmentsAsync();
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء حذف الموعد. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}