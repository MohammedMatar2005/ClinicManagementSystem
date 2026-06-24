using ClinicBusiness.Services;
using ClinicBusiness.Models;
using System;
using System.Data;
using System.Windows.Forms;
using ClinicBusiness.Utils;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChooseAppointment : Form
    {
        // 1. تعريف الـ BindingSource على مستوى الكلاس بدلاً من DataView
        private BindingSource _appointmentsBindingSource = new BindingSource();
        private readonly ClinicManagementSystemContext _context;

        public int AppointmentId { get; private set; }
        public string PatientName { get; private set; }

        public frmChooseAppointment()
        {
            InitializeComponent();
            _context = new ClinicManagementSystemContext();
        }

        private void frmChooseAppointment_Load(object sender, EventArgs e)
        {
            _ConfigureDataGridView();
            _LoadAllAppointments();

            txtSearch.ForeColor = System.Drawing.Color.Black;
        }

        private void _ConfigureDataGridView()
        {
            dgvAppointments.AutoGenerateColumns = false;

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

        private async void _LoadAllAppointments()
        {
            try
            {
                clsAppointment appointmentService = new clsAppointment(_context);
                var appointmentsList = await appointmentService.GetAllAppointmentsAsync();

                if (appointmentsList != null)
                {
                    // تحويل الـ List إلى DataTable لتفعيل ميزة الـ Filter داخل الـ BindingSource
                    DataTable dtAppointments = ConvertToDataTable._ConvertToDataTable(appointmentsList);

                    // 2. إسناد الـ DataTable للـ BindingSource
                    _appointmentsBindingSource.DataSource = dtAppointments;

                    // 3. ربط الـ DataGridView بالـ BindingSource مباشرة
                    dgvAppointments.DataSource = _appointmentsBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات المواعيد: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_appointmentsBindingSource.DataSource == null) return;
            if (txtSearch.Text == "🔍 أدخل اسم المريض أو الطبيب للبحث...") return;

            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText))
            {
                // إلغاء الفلترة ببساطة
                _appointmentsBindingSource.RemoveFilter();
                return;
            }

            // 4. استخدام خاصية الـ Filter الخاصة بالـ BindingSource مباشرة
            _appointmentsBindingSource.Filter = string.Format("PatientFullName LIKE '%{0}%' OR DoctorFullName LIKE '%{0}%'", filterText);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _SelectAndClose();
        }

        private void dgvAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _SelectAndClose();
        }

        private void _SelectAndClose()
        {
            // 5. استخدام الـ Current الخاص بالـ BindingSource للوصول السريع للـ Row الحالي والمختار بأمان
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
    }
}