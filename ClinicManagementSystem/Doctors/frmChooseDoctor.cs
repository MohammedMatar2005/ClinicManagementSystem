using ClinicBusiness.DTO.DoctorsDTOs;
using ClinicBusiness.Services;
using ClinicBusiness.Models; // الاعتماد على الموديلز الجديدة الموحدة
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChooseDoctor : Form
    {
        // 1. استخدام الـ BindingSource للتحكم بالفلترة والسطر الحالي
        private BindingSource _doctorsBindingSource = new BindingSource();
        private readonly ClinicManagementSystemContext _context;

        clsDoctor _doctorService;

        // خصائص عامة لقراءة البيانات من الفورم
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
            _LoadAllDoctors();

            txtSearch.ForeColor = System.Drawing.Color.Black;
        }

        private void _ConfigureDataGridView()
        {
            // 🛠️ منع توليد أعمدة عشوائية زائدة
            dgvDoctors.AutoGenerateColumns = false;

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
        }

        // دالة مساعدة لتحويل الـ List إلى DataTable لتشغيل الـ Filter في الـ BindingSource
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
                // تمرير الـ Context مباشرة للسيرفس بعد إلغاء الـ Repositories
                clsDoctor doctorService = new clsDoctor(_context);
                var doctorsList = await doctorService.GetAllDoctorsAsync();

                if (doctorsList != null)
                {
                    DataTable dtDoctors = _ConvertToDataTable(doctorsList);

                    // 2. إسناد الـ DataTable للـ BindingSource وربطه بالـ DataGridView
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_doctorsBindingSource.DataSource == null) return;

            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText))
            {
                // 3. إلغاء الفلترة عبر الـ BindingSource
                _doctorsBindingSource.RemoveFilter();
                return;
            }

            // 4. الفلترة المباشرة داخل الـ BindingSource
            _doctorsBindingSource.Filter = string.Format("DoctorFullName LIKE '%{0}%'", filterText);
        }

        private void _SelectAndClose()
        {
            // 5. قراءة السطر الحالي المختار من خلال الـ BindingSource بأمان وسرعة
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
            int doctorId = (int)dgvDoctors.CurrentRow.Cells["DoctorId"].Value;

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
        }

        private async void toolStripDeleteDoctor_Click(object sender, EventArgs e)
        {

            if (dgvDoctors.CurrentRow == null) return;

            int doctorId = (int)dgvDoctors.CurrentRow.Cells["DoctorId"].Value;

            if (doctorId <= 0) return;


            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا الطبيب؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = await _doctorService.DeleteDoctorAsync(doctorId);

                if (isDeleted)
                {
                    MessageBox.Show("تم حذف الطبيب بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("فشلت عملية الحذف، قد يكون الطبيب مرتبطاً ببيانات أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {

        }

        private async Task toolStripUpdateDoctorData_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow == null) return;

            // جلب معرف الطبيب من السطر الحالي للـ Grid
            int doctorId = (int)dgvDoctors.CurrentRow.Cells["DoctorId"].Value;
            if (doctorId <= 0) return;

            // فتح فورم التعديل مع تمرير الـ ID المختار
            using (frmAddUpdateDoctor frm = new frmAddUpdateDoctor(doctorId))
            {
                // إذا تمت عملية التحديث بنجاح وضغط المستخدم حفظ، سيعود الـ DialogResult بـ OK
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // تحديث قائمة الأطباء في الـ Grid لتعكس التعديلات الجديدة فوراً
                    frmChooseDoctor_Load(null, null);
                }
            }
        }
    }
}