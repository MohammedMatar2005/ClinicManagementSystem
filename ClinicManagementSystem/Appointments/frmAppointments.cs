using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using ClinicBusiness.Services;
using ClinicBusiness.DTO.AppointmentsDTOs;
using ClinicDataAccess.Data;
using ClinicDataAccess.Repositories;
using ClinicManagementSystem.Appointments;

namespace ClinicManagementSystem
{
    public partial class frmAppointments : Form
    {
        // تعريف الخدمة والـ DataView المسؤول عن الفلترة المحلية في الذاكرة
        private readonly clsAppointment _appointmentService;
        private DataView _appointmentsDataView = new DataView();

        // متغير على مستوى الكلاس للاحتفاظ برقم المريض المختار
        private int _selectedPatientId = -1;
        private int _selectedDoctorId;

        public frmAppointments()
        {
            InitializeComponent();

            // تجهيز سياق البيانات وحقن المستودع داخل الخدمة
            var context = new ClinicManagementSystemContext();
            var repo = new AppointmentRepository(context);
            _appointmentService = new clsAppointment(repo);
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
            // منع الـ Grid من إنشاء أعمدة تلقائية إضافية
            dgvAppointments.AutoGenerateColumns = false;

            // ربط أعمدة الـ DataGridView بالأسماء التي سنعرفها في الـ DataTable
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
                // 1. جلب القائمة كاملة لمرة واحدة من الـ Business Layer
                List<AppointmentViewDTO> appointmentsList = await _appointmentService.GetAllAppointmentsAsync();

                // 2. بناء الـ DataTable وتحويل البيانات إليها لتفعيل الـ RowFilter السريع
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

                // 3. إسناد الـ DefaultView للمتغير العام وربطه بالواجهة
                _appointmentsDataView = dt.DefaultView;
                dgvAppointments.DataSource = _appointmentsDataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب المواعيد من السيرفر: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _selectedPatientId = -1;
            txtDoctorId.Clear();

            // إذا كان لديك تكست بوكس لاسم المريض قم بتنظيفه هنا أيضاً:
            // txtPatientName.Clear();
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
            // فتح شاشة الاختيار التي صممناها بشكل منبثق (Using لضمان تدمير الكائن فوراً وتحرير الذاكرة)
            using (frmChoosePatient frm = new frmChoosePatient())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // 🎯 قراءة المعرف والاسم بناءً على الخصائص المحدثة بالريبو باترن
                    _selectedPatientId = frm.PatientId;

                    // إسناد رقم المريض للتكست بوكس الخاص به لتثبيته في الواجهة
                    txtPatinetId.Text = _selectedPatientId.ToString();

                    // إذا كان لديك تكست بوكس يعرض اسم المريض لموظف الاستقبال ليتأكد:
                    // txtPatientName.Text = frm.SelectedPatientName;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من أن الموظف قام باختيار مريض فعلاً قبل الحفظ لحماية قاعدة البيانات
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


            if(await _appointmentService.IsPatientAvailableAsync(_selectedPatientId, dtpAppointmentDate.Value) == false)
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
                DoctorId = _selectedDoctorId, // طبيب افتراضي أو يتم جلب معرّفه من ComboBox الأطباء
                PatientId = _selectedPatientId, // 🎯 تم الإسناد الصحيح هنا لـ رقم المريض المختار
                AppointmentStatusId = cmbStatus.SelectedIndex + 1,
                Notes = txtNotes.Text.Trim()
            };

            int newAppointmentId = await _appointmentService.AddNewAppointmentAsync(appointment);

            // هنا يمكنك استدعاء دالة الحفظ وإرسال الكائن للـ Service:
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
                    // 🎯 قراءة المعرف والاسم بناءً على الخصائص المحدثة بالريبو باترن
                    _selectedDoctorId = frm.DoctorId;

                    // إسناد رقم الطبيب للتكست بوكس الخاص به لتثبيته في الواجهة
                    txtDoctorId.Text = _selectedDoctorId.ToString();

                    // إذا كان لديك تكست بوكس يعرض اسم المريض لموظف الاستقبال ليتأكد:
                    // txtPatientName.Text = frm.SelectedPatientName;
                }
            }
        }

        private void AddNewAppointmentMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
    }
}