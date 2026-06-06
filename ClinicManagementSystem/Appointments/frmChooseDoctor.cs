using ClinicBusiness.Services;
using ClinicDataAccess.Data;
using ClinicDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChooseDoctor : Form
    {
        private readonly DoctorRepository _doctorRepository;

        // 🎯 المتغير المسؤول عن سرعة الفلترة اللحظية للأطباء في الذاكرة
        private DataView _dvDoctors = new DataView();

        // خصائص عامة لقراءة بيانات الطبيب المختار من فورم المواعيد
        public int DoctorId { get; private set; } = -1;
        public string DoctorName { get; private set; } = string.Empty;

        public frmChooseDoctor()
        {
            InitializeComponent();

            var context = new ClinicManagementSystemContext();
            _doctorRepository = new DoctorRepository(context);
        }

        private void frmChooseDoctor_Load(object sender, EventArgs e)
        {
            // منع توليد أعمدة عشوائية زائدة في جدول الأطباء
            dgvDoctors.AutoGenerateColumns = false;

            // بناء وتنسيق هيكل جدول الأطباء برمجياً بالترتيب الصحيح
            _BuildGridColumnsStructure();

            _LoadAllDoctors();

            txtSearch.Text = "";
            txtSearch.ForeColor = System.Drawing.Color.Black;
        }

        private void _BuildGridColumnsStructure()
        {
            // تنظيف الجدول لضمان عدم التكرار
            dgvDoctors.Columns.Clear();

            // 1. رقم الطبيب
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DoctorId",
                DataPropertyName = "DoctorId", // 💡 يجب أن يطابق اسم الخاصية في الـ DTO الخاص بالطبيب حرفياً
                HeaderText = "رقم الطبيب",
                Width = 90
            });

            // 2. رقم الشخص
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonId",
                DataPropertyName = "PersonId",
                HeaderText = "رقم الشخص",
                Width = 90
            });

            // 3. الاسم الكامل للطبيب
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DoctorFullName",
                DataPropertyName = "DoctorFullName", // 💡 تأكد من مسماها في كلاس الطبيب (DoctorFullName أو FullName)
                HeaderText = "الاسم الكامل للطبيب",
                Width = 220
            });

            // 4. الرقم الوطني للطبيب
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NationalNumber",
                DataPropertyName = "NationalNumber",
                HeaderText = "الرقم الوطني",
                Width = 150
            });

            // 5. رقم جوال الطبيب
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PhoneNumber",
                DataPropertyName = "PhoneNumber",
                HeaderText = "رقم الجوال",
                Width = 150
            });

            // 6. حالة الطبيب (على رأس عمله / نشط)
            dgvDoctors.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsActive",
                DataPropertyName = "IsActive",
                HeaderText = "نشط؟",
                Width = 80,
                FlatStyle = FlatStyle.Flat
            });
        }

        private async void _LoadAllDoctors()
        {
            try
            {
                // استدعاء البزنس الخاص بالأطباء
                clsDoctor doctorService = new clsDoctor(_doctorRepository);
                var doctorsList = await doctorService.GetAllDoctorsAsync(); // 💡 تأكد من اسم الدالة في كلاس clsDoctor

                if (doctorsList != null)
                {
                    // تحويل الـ List إلى DataTable لتفعيل الفلترة المحلية الفورية
                    DataTable dtDoctors = _ConvertToDataTable(doctorsList);

                    _dvDoctors = dtDoctors.DefaultView;
                    dgvDoctors.DataSource = _dvDoctors;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الأطباء: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable _ConvertToDataTable<T>(IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        // الفلترة اللحظية للأطباء بناءً على الرقم الوطني أو رقم الجوال المكتوب
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_dvDoctors.Table == null) return;

            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText) || filterText.Contains("🔍"))
            {
                _dvDoctors.RowFilter = "";
                return;
            }

            // الفلترة المرنة: تبحث تلقائياً بالرقم الوطني أو برقم الجوال للأطباء
            _dvDoctors.RowFilter = string.Format("NationalNumber LIKE '{0}%' OR PhoneNumber LIKE '{0}%'", filterText);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _SelectAndClose();
        }

        private void dgvDoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _SelectAndClose();
            }
        }

        private void _SelectAndClose()
        {
            if (dgvDoctors.CurrentRow != null)
            {
                // تحذير حماية: منع حجز موعد عند طبيب غير نشط أو مجاز
                bool isActive = Convert.ToBoolean(dgvDoctors.CurrentRow.Cells["IsActive"].Value);
                if (!isActive)
                {
                    MessageBox.Show("لا يمكن اختيار هذا الطبيب لأنه غير نشط في النظام حالياً!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // سحب البيانات برمجياً وإغلاق الفورم بنجاح
                DoctorId = Convert.ToInt32(dgvDoctors.CurrentRow.Cells["DoctorId"].Value);
                DoctorName = dgvDoctors.CurrentRow.Cells["DoctorFullName"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار طبيب من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // منع إدخال الحروف نهائياً في حقل البحث لضمان البحث عن أرقام الهويات أو الهواتف فقط
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}