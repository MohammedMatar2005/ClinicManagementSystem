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
    public partial class frmChoosePatient : Form
    {
        private readonly PatientRepository _patientRepository;

        // 🎯 هذا المتغير هو سر سرعة الفلترة اللحظية في الذاكرة
        private DataView _dvPatients = new DataView();

        // خصائص عامة لقراءة البيانات من فورم المواعيد (تطابق الكود الحالي لديك)
        public int PatientId { get; private set; } = -1;
        public string PatientName { get; private set; } = string.Empty;

        public frmChoosePatient()
        {
            InitializeComponent();

            var context = new ClinicManagementSystemContext();
            _patientRepository = new PatientRepository(context);
        }

        private void frmChoosePatient_Load(object sender, EventArgs e)
        {
            // 🛠️ منع توليد أعمدة عشوائية زائدة عن الأربعة المطلوبة
            dgvPatients.AutoGenerateColumns = false;

            // بناء وتنسيق هيكل الجدول بالترتيب الصحيح
            _BuildGridColumnsStructure();

            _LoadAllPatients();

            txtSearch.Text = "";
            txtSearch.ForeColor = System.Drawing.Color.Black;
        }

        private void _BuildGridColumnsStructure()
        {
            dgvPatients.Columns.Clear();

            // 1. رقم المريض
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PatientId",
                DataPropertyName = "PatientId",
                HeaderText = "رقم المريض",
                Width = 90
            });

            // 2. رقم الشخص
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonId",
                DataPropertyName = "PersonId",
                HeaderText = "رقم الشخص",
                Width = 90
            });

            // 3. الاسم الكامل
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PatientFullName",
                DataPropertyName = "PatientFullName",
                HeaderText = "الاسم الكامل للمريض",
                Width = 220
            });

            // 4. الرقم الوطني 
            // 💡 تنبيه: إذا لم يظهر، تأكد هل اسم الخاصية في الكلاس: NationalNumber أم NationalId أم NationalID؟
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NationalNumber",
                DataPropertyName = "NationalNumber", // 👈 يجب أن يطابق اسم الخاصية في الـ DTO حرفياً
                HeaderText = "الرقم الوطني",
                Width = 150
            });

            // 5. رقم الجوال
            // 💡 تنبيه: إذا لم يظهر، تأكد هل اسم الخاصية في الكلاس: Phone أم PhoneNumber؟
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PhoneNumber",
                DataPropertyName = "PhoneNumber", // 👈 يجب أن يطابق اسم الخاصية في الـ DTO حرفياً
                HeaderText = "رقم الجوال",
                Width = 150
            });

            // 6. حالة الحساب
            dgvPatients.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsActive",
                DataPropertyName = "IsActive",
                HeaderText = "نشط؟",
                Width = 80,
                FlatStyle = FlatStyle.Flat
            });
        }

        private void dgvAppointmentsColumnsClear()
        {
            dgvPatients.Columns.Clear();
        }

        private async void _LoadAllPatients()
        {
            try
            {
                clsPatient patient = new clsPatient(_patientRepository);
                var patientsList = await patient.GetAllPatientsAsync();

                if (patientsList != null)
                {
                    DataTable dtPatients = _ConvertToDataTable(patientsList);

                    // 🎯 الإصلاح الجذري: ربط الـ DataView بالجدول وإسناده للـ GridView لتفعيل الفلترة
                    _dvPatients = dtPatients.DefaultView;
                    dgvPatients.DataSource = _dvPatients;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات المرضى: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // الفلترة اللحظية (Real-time Filtering) تعمل الآن 100%
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_dvPatients.Table == null) return;

            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText) || filterText.Contains("🔍"))
            {
                _dvPatients.RowFilter = "";
                return;
            }

            // الفلترة بناءً على حقل الرقم الوطني المظبوط بالـ DataTable
            _dvPatients.RowFilter = string.Format("NationalNumber LIKE '{0}%'", filterText);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _SelectAndClose();
        }

        private void dgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _SelectAndClose();
            }
        }

        private void _SelectAndClose()
        {
            if (dgvPatients.CurrentRow != null)
            {
                // سحب القيمة المحددة بناءً على أسماء الخلايا (Columns Names) التي صممناها في الدالة بالأعلى
                PatientId = Convert.ToInt32(dgvPatients.CurrentRow.Cells["PatientId"].Value);
                PatientName = dgvPatients.CurrentRow.Cells["PatientFullName"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار مريض من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // الفحص: إذا كان المفتاح المضغوط ليس رقماً وليس من أزرار التحكم (كالـ Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // إلغاء الحدث ومنع الحرف من الظهور داخل التكست بوكس
                e.Handled = true;
            }
        }
    }
}