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

        public frmAppointments()
        {
            InitializeComponent();

            // ملاحظة معمارية: في المشاريع الكبيرة يتم حقن الخدمة عبر الـ DI Container
            // للتبسيط نقوم بتهيئة الطبقات هنا تتابعاً بناءً على النمط المتبع لديك
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

                // 2. بناء الـ DataTable وتحويل البيانات إليها لتفعيل الـ RowFilter
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

            // إذا كان حقل البحث فارغاً، قم بإلغاء الفلترة فوراً لعرض كل المواعيد واخرج
            if (string.IsNullOrEmpty(searchValue))
            {
                _appointmentsDataView.RowFilter = string.Empty;
                return;
            }

            try
            {
                if (cmbSearchType.SelectedIndex == 0)
                {
                    // الفلترة بالـ ID (رقمي): نفحص أولاً أن المدخل رقمي لمنع انهيار البرنامج
                    if (int.TryParse(searchValue, out int id))
                    {
                        _appointmentsDataView.RowFilter = $"AppointmentId = {id}";
                    }
                    else
                    {
                        _appointmentsDataView.RowFilter = "1 = 0"; // تصفير النتائج إذا كتب حروفاً في خانة الرقم
                    }
                }
                else if (cmbSearchType.SelectedIndex == 1)
                {
                    // الفلترة بالرقم الوطني (نصي): يبحث عن أي سجل يحتوي على الأرقام المكتوبة
                    _appointmentsDataView.RowFilter = $"PatientNationalNumber LIKE '%{searchValue}%'";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"خطأ أثناء الفلترة اللحظية: {ex.Message}");
            }
        }
        f
        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // بما أن الـ ID والرقم الوطني يعتمدان على الأرقام فقط، نمنع إدخال الحروف نهائياً لحماية النظام
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ClearAllFields()
        {
            txtSearchValue.Clear();
            cmbSearchType.SelectedIndex = 0;
            _appointmentsDataView.RowFilter = string.Empty; // إلغاء الفلترة لعرض كل المواعيد
            cmbStatus.SelectedIndex = 0;
            txtReason.Clear();
            txtNotes.Clear();
            txtPatinetId.Clear();


        }

        private async void DeleteAppointmentMenuItem_Click(object sender, EventArgs e)
        {
            // التأكد من وجود صف محدد لمنع الـ NullReferenceException
            if (dgvAppointments.SelectedRows.Count == 0) return;

            // جلب رقم الموعد بناءً على اسم العمود في الـ Designer لديك
            int appointmentId = (int)dgvAppointments.SelectedRows[0].Cells["colAppointmentId"].Value;
            if (appointmentId == 0) return;

            // 1. إظهار مسج بوكس التأكيد قبل الحذف
            DialogResult result = MessageBox.Show(
                $"هل أنت متأكد من رغبتك في حذف الموعد رقم ({appointmentId}) بشكل نهائي؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); // يجعل خيار "لا" هو النشط افتراضياً لحماية البيانات من النقرات السريعة

            // 2. إذا ضغط الموظف "نعم" يبدأ الحذف
            if (result == DialogResult.Yes)
            {
                // استخدام await هنا يضمن بقاء الشاشة مرنة وبدون تعليق (Deadlock)
                bool isDeleted = await _appointmentService.DeleteAppointmentAsync(appointmentId);

                if (isDeleted)
                {
                    MessageBox.Show("تم حذف الموعد بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تحديث جدول المواعيد تلقائياً بعد الحذف
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
            // التأكد من وجود صف محدد لمنع الـ NullReferenceException
            if (dgvAppointments.SelectedRows.Count == 0) return;

            // جلب رقم الموعد بناءً على اسم العمود في الـ Designer لديك
            int appointmentId = (int)dgvAppointments.SelectedRows[0].Cells["colAppointmentId"].Value;
            if (appointmentId == 0) return;

            // إنشاء نموذج عرض معلومات الموعد وتمرير رقم الموعد
            var showInfoForm = new frmShowAppointmentInfo(appointmentId);
            showInfoForm.ShowDialog();
        }
    }
}