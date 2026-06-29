using ClinicBusiness.Services;
using ClinicBusiness.Models; // الاعتماد على الموديلز الموحدة للبزنس
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChoosePatient : Form
    {
        // 1. استخدام الـ BindingSource للتحكم بالفلترة والسطر الحالي
        private BindingSource _patientsBindingSource = new BindingSource();
        private readonly ClinicManagementSystemContext _context;

        // خصائص عامة لقراءة البيانات من فورم المواعيد
        public int PatientId { get; private set; } = -1;
        public string PatientName { get; private set; } = string.Empty;

        public frmChoosePatient()
        {
            InitializeComponent();

            // حقن الـ Context مباشرة للفورم
            _context = new ClinicManagementSystemContext();
        }

        private void frmChoosePatient_Load(object sender, EventArgs e)
        {
            // منع توليد أعمدة عشوائية زائدة
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
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NationalNumber",
                DataPropertyName = "NationalNumber",
                HeaderText = "الرقم الوطني",
                Width = 150
            });

            // 5. رقم الجوال
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PhoneNumber",
                DataPropertyName = "PhoneNumber",
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

        private async void _LoadAllPatients()
        {
            try
            {
                // تمرير الـ Context مباشرة للسيرفس بعد إلغاء الـ Repositories
                clsPatient patientService = new clsPatient(_context);
                var patientsList = await patientService.GetAllPatientsAsync();

                if (patientsList != null)
                {
                    DataTable dtPatients = _ConvertToDataTable(patientsList);

                    // 2. إسناد الـ DataTable للـ BindingSource وربطه بالـ DataGridView
                    _patientsBindingSource.DataSource = dtPatients;
                    dgvPatients.DataSource = _patientsBindingSource;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_patientsBindingSource.DataSource == null) return;

            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText) || filterText.Contains("🔍"))
            {
                // 3. إلغاء الفلترة عبر الـ BindingSource
                _patientsBindingSource.RemoveFilter();
                return;
            }

            // 4. الفلترة المباشرة اللحظية داخل الـ BindingSource بناءً على الرقم الوطني
            _patientsBindingSource.Filter = string.Format("NationalNumber LIKE '{0}%'", filterText);
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
            // 5. قراءة السطر الحالي المختار من خلال الـ BindingSource بأمان وسرعة وبدون NullReference
            if (_patientsBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)_patientsBindingSource.Current;

                PatientId = Convert.ToInt32(currentRow["PatientId"]);
                PatientName = Convert.ToString(currentRow["PatientFullName"]);

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
            // يمكنك فتح شاشة إضافة مريض جديد هنا لاحقاً إذا أردت
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // منع إدخال أي شيء عدا الأرقام وأزرار التحكم في خانة البحث عن الرقم الوطني
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}