using ClinicBusiness.DTO.AppointmentsDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicBusiness.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChooseAppointment : Form
    {
        // 1. تعريف الـ BindingSource على مستوى الكلاس بدلاً من DataView
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

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            using (frmAppointments frm = new frmAppointments())
            {
                // 2. فتح الفورم بشكل حواري (سيجعل الفورم الصغير خلفه مباشرة وغير قابل للنقر)
                frm.ShowDialog();

                // 3. (اختياري) إذا كنت تريد تحديث البيانات في الفورم الحالي بعد إغلاق فورم المواعيد:
                // _RefreshData(); 
            }
        }

        private void toolStripShowAppointmentInfo_Click(object sender, EventArgs e)
        {
            int _selectedAppointmentId = 0;

            _selectedAppointmentId = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["AppointmentId"].Value);

            using (frmShowAppointmentInfo frm = new frmShowAppointmentInfo(_selectedAppointmentId))
            {
                frm.ShowDialog();
            }
        }

        private void toolStripUpdateAppointment_Click(object sender, EventArgs e)
        {
            int _selectedAppointmentId = 0;

            _selectedAppointmentId = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["AppointmentId"].Value);

            using (frmUpdateAppointment frm = new frmUpdateAppointment(_selectedAppointmentId))
            {
                frm.ShowDialog();
            }
        }

        private void toolStripAddNewAppointment_Click(object sender, EventArgs e)
        {
            using (frmAppointments frm = new frmAppointments())
            {
                // 2. فتح الفورم بشكل حواري (سيجعل الفورم الصغير خلفه مباشرة وغير قابل للنقر)
                frm.ShowDialog();

                // 3. (اختياري) إذا كنت تريد تحديث البيانات في الفورم الحالي بعد إغلاق فورم المواعيد:
                // _RefreshData(); 
            }
        }

        private async void toolStripDeleteAppointmen_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0) return;

            int appointmentId = (int)dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value;
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


              

                // 3. ربط الـ DataGridView بالـ BindingSource مباشرة
                dgvAppointments.DataSource = _appointmentsBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب المواعيد: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}