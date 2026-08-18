using ClinicBusiness.Models;
using ClinicBusiness.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChoosePatient : Form
    {
        private BindingSource _patientsBindingSource = new BindingSource();
        private readonly ClinicManagementSystemContext _context;
        private clsPatient _patientService;

        // خصائص عامة لقراءة البيانات عند اختيار مريض
        public int PatientId { get; private set; } = -1;
        public string PatientName { get; private set; } = string.Empty;

        public frmChoosePatient()
        {
            InitializeComponent();

            _context = new ClinicManagementSystemContext();
            _patientService = new clsPatient(_context);
        }

        private void frmChoosePatient_Load(object sender, EventArgs e)
        {
            dgvPatients.AutoGenerateColumns = false;

            _BuildGridColumnsStructure();
            _LoadAllPatients();

            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
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
                this.Cursor = Cursors.WaitCursor;

                var patientsList = await _patientService.GetAllPatientsAsync();

                if (patientsList != null)
                {
                    DataTable dtPatients = _ConvertToDataTable(patientsList);

                    _patientsBindingSource.DataSource = dtPatients;
                    dgvPatients.DataSource = _patientsBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات المرضى: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
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

        // ==================== آلية البحث المحدثة والمعيارية ====================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_patientsBindingSource.DataSource == null) return;

            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            // في حال كانت الخانة فارغة أو تحتوي على النص التوضيحي الافتراضي
            if (string.IsNullOrEmpty(filterText) || filterText.Contains("🔍"))
            {
                _patientsBindingSource.RemoveFilter();
                return;
            }

            // الفلترة بالرقم الوطني أو بالاسم الكامل مطابقة لباقي الشاشات
            _patientsBindingSource.Filter = string.Format(
                "NationalNumber LIKE '%{0}%' OR PatientFullName LIKE '%{0}%'",
                filterText
            );
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام والحروف والتحكم (لتمكين البحث بالاسم أيضاً)
            // إذا كنت تريد إبقاء البحث شاملاً للأرقام والأسماء لا نقيد الإدخال بالأرقام فقط
        }

        // ======================================================================

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
            _OpenAddPatientForm();
        }

        private void tsmiAddNewPatient_Click(object sender, EventArgs e)
        {
            _OpenAddPatientForm();
        }

        private void _OpenAddPatientForm()
        {
            using (Form frm = new frmAddUpdatePatient())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _LoadAllPatients();
                }
            }
        }

        private void tsmiViewPatientDetails_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null) return;

            var selectedPatientId = Convert.ToInt32(dgvPatients.CurrentRow.Cells["PatientId"].Value);

            using (Form frm = new frmShowPatientInfo(selectedPatientId))
            {
                frm.ShowDialog();
            }
        }

        private async void tsmiDeletePatient_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null) return;

            int patientId = Convert.ToInt32(dgvPatients.CurrentRow.Cells["PatientId"].Value);

            if (patientId <= 0) return;

            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا المريض؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = await _patientService.DeletePatientAsync(patientId);

                if (isDeleted)
                {
                    MessageBox.Show("تم حذف المريض بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadAllPatients(); // إعادة تحميل القائمة بعد الحذف مباشرة
                }
                else
                {
                    MessageBox.Show("فشلت عملية الحذف، قد يكون المريض مرتبطاً ببيانات أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cmbSearchType.Text != "بلا");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else
            {
                _patientsBindingSource.RemoveFilter();
            }
        }

        private void tsmiUpdatePatientInfo_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(dgvPatients.CurrentRow.Cells["PatientId"].Value);

            if (patientId <= 0) return;


            using (Form frm = new frmAddUpdatePatient(patientId))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _LoadAllPatients();
                }
            }

        }
    }
}