using ClinicBusiness.DTO.DoctorsDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChooseDoctor : Form
    {
        private BindingSource _doctorsBindingSource = new BindingSource();
        private readonly ClinicManagementSystemContext _context;
        private clsDoctor _doctorService;

        public int DoctorId { get; private set; } = -1;
        public string DoctorName { get; private set; } = string.Empty;

        public frmChooseDoctor()
        {
            InitializeComponent();
            _context = new ClinicManagementSystemContext();
            _doctorService = new clsDoctor(_context);
        }

        private void frmChooseDoctor_Load(object sender, EventArgs e)
        {
            _ConfigureDataGridView();
            cmbSearchType.SelectedIndex = 0; // الخيار الافتراضي: "بلا"
            _LoadAllDoctors();
        }

        private void _ConfigureDataGridView()
        {
            dgvDoctors.AutoGenerateColumns = false;
            dgvDoctors.Columns.Clear();

            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DoctorId",
                HeaderText = "رقم الطبيب",
                DataPropertyName = "DoctorId"
            });

            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DoctorFullName",
                HeaderText = "اسم الطبيب بالكامل",
                DataPropertyName = "DoctorFullName"
            });

            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Specialization",
                HeaderText = "التخصص",
                DataPropertyName = "Specialization"
            });

            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PhoneNumber",
                HeaderText = "رقم الهاتف",
                DataPropertyName = "PhoneNumber"
            });

            dgvDoctors.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsActive",
                HeaderText = "نشط",
                DataPropertyName = "IsActive"
            });

            dgvDoctors.Columns["DoctorId"].Width = 90;
            dgvDoctors.Columns["IsActive"].Width = 60;
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

        private async void _LoadAllDoctors()
        {
            try
            {
                var doctorsList = await _doctorService.GetAllDoctorsAsync();

                if (doctorsList != null)
                {
                    DataTable dtDoctors = _ConvertToDataTable(doctorsList);
                    _doctorsBindingSource.DataSource = dtDoctors;
                    dgvDoctors.DataSource = _doctorsBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الأطباء: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllFields()
        {
            txtSearch.Text = string.Empty;
            _doctorsBindingSource.RemoveFilter();
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
            // تقييد إدخال الأرقام فقط في الحقول الرقمية الصريحة مثل رقم الطبيب
            if (cmbSearchType.Text == "رقم الطبيب")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_doctorsBindingSource.DataSource == null) return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(searchValue) || cmbSearchType.Text == "بلا")
            {
                _doctorsBindingSource.RemoveFilter();
                return;
            }

            switch (cmbSearchType.Text)
            {
                case "رقم الطبيب":
                    if (int.TryParse(searchValue, out int id))
                    {
                        _doctorsBindingSource.Filter = $"DoctorId = {id}";
                    }
                    else
                    {
                        _doctorsBindingSource.RemoveFilter();
                    }
                    break;

                case "اسم الطبيب":
                    _doctorsBindingSource.Filter = $"DoctorFullName LIKE '%{searchValue}%'";
                    break;

                case "التخصص":
                    _doctorsBindingSource.Filter = $"Specialization LIKE '%{searchValue}%'";
                    break;

                case "رقم الهاتف":
                    _doctorsBindingSource.Filter = $"PhoneNumber LIKE '%{searchValue}%'";
                    break;

                default:
                    _doctorsBindingSource.RemoveFilter();
                    break;
            }
        }

        private void _SelectAndClose()
        {
            if (_doctorsBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)_doctorsBindingSource.Current;

                bool isActive = Convert.ToBoolean(currentRow["IsActive"]);

                if (!isActive)
                {
                    MessageBox.Show("لا يمكن اختيار طبيب غير نشط!",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DoctorId = Convert.ToInt32(currentRow["DoctorId"]);
                DoctorName = Convert.ToString(currentRow["DoctorFullName"]);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار طبيب من القائمة أولاً.",
                    "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _SelectAndClose();
        }

        private void dgvDoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                _SelectAndClose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolStripShowDoctorInfo_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow == null) return;

            int doctorId = Convert.ToInt32(dgvDoctors.CurrentRow.Cells["DoctorId"].Value);

            using (frmShowDoctorInfo frm = new frmShowDoctorInfo(doctorId))
            {
                frm.ShowDialog();
            }
        }

        private void toolStripAddNewDoctor_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateDoctor frm = new frmAddUpdateDoctor())
            {
                frm.ShowDialog();
            }

            _LoadAllDoctors();
        }

        private void toolStripUpdateDoctorData_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow == null) return;

            int doctorId = Convert.ToInt32(dgvDoctors.CurrentRow.Cells["DoctorId"].Value);
            if (doctorId <= 0) return;

            using (frmAddUpdateDoctor frm = new frmAddUpdateDoctor(doctorId))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _LoadAllDoctors();
                }
            }
        }

        private async void toolStripDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow == null) return;

            int doctorId = Convert.ToInt32(dgvDoctors.CurrentRow.Cells["DoctorId"].Value);
            if (doctorId <= 0) return;

            DialogResult result = MessageBox.Show(
                $"هل أنت متأكد من حذف الطبيب رقم ({doctorId})؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = await _doctorService.DeleteDoctorAsync(doctorId);

                if (isDeleted)
                {
                    MessageBox.Show("تم حذف الطبيب بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadAllDoctors();
                }
                else
                {
                    MessageBox.Show("فشلت عملية الحذف، قد يكون الطبيب مرتبطاً ببيانات أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateDoctor frm = new frmAddUpdateDoctor())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _LoadAllDoctors();
                }
            }
        }
    }
}