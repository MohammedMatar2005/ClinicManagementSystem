using ClinicBusiness.Services;
using ClinicBusiness.Models; // الاعتماد على الموديلز الموحدة للبزنس
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ClinicBusiness.Utils;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChoosePatientVisit : Form
    {
        // 1. استخدام الـ BindingSource للتحكم بالفلترة والسطر الحالي
        private BindingSource _visitsBindingSource = new BindingSource();
        private readonly ClinicManagementSystemContext _context;

        // خصائص عامة لقراءة البيانات من فورم المواعيد بعد الإغلاق
        public int PatientVisitId { get; private set; } = -1;
        public string DoctorName { get; private set; } = string.Empty;

        private readonly int _patientId;

        public frmChoosePatientVisit()
        {
            InitializeComponent();

            // حقن الـ Context مباشرة للفورم
            _context = new ClinicManagementSystemContext();
        }

        private void frmChoosePatientVisit_Load(object sender, EventArgs e)
        {
            dgvVisits.AutoGenerateColumns = false;

            _BuildGridColumnsStructure();
            _LoadAllVisits();

            txtSearch.Text = "";
            txtSearch.ForeColor = System.Drawing.Color.Black;
        }

        private void _BuildGridColumnsStructure()
        {
            dgvVisits.Columns.Clear();

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VisitId",
                DataPropertyName = "VisitId",
                HeaderText = "رقم الزيارة",
                Width = 90
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PatientFullName",
                DataPropertyName = "PatientFullName",
                HeaderText = "اسم المريض",
                Width = 150
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VisitDate",
                DataPropertyName = "VisitDate",
                HeaderText = "تاريخ الزيارة",
                Width = 130
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DoctorFullName",
                DataPropertyName = "DoctorFullName",
                HeaderText = "اسم الطبيب المعالج",
                Width = 200
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AppointmentReason",
                DataPropertyName = "AppointmentReason",
                HeaderText = "سبب الموعد",
                Width = 180
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Diagnosis",
                DataPropertyName = "Diagnosis",
                HeaderText = "التشخيص الطبي",
                Width = 220
            });
        }

        private async void _LoadAllVisits()
        {
            try
            {
                // تمرير الـ Context مباشرة للسيرفس بعد إلغاء الـ Repositories
                clsPatientVisit patientVisitService = new clsPatientVisit(_context);
                var visitsList = await patientVisitService.GetAllPatientVisitsAsync();

                if (visitsList != null)
                {
                    // تحويل الـ List إلى DataTable لتفعيل خاصية الـ Filter في الـ BindingSource
                    DataTable dtVisits = ConvertToDataTable._ConvertToDataTable(visitsList);

                    // 2. إسناد الـ DataTable للـ BindingSource وربطه بالـ DataGridView
                    _visitsBindingSource.DataSource = dtVisits;
                    dgvVisits.DataSource = _visitsBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الزيارات: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_visitsBindingSource.DataSource == null) return;

            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText))
            {
                // 3. إلغاء الفلترة عبر الـ BindingSource
                _visitsBindingSource.RemoveFilter();
                return;
            }

            // 4. الفلترة المباشرة اللحظية داخل الـ BindingSource بناءً على اسم الدكتور
            _visitsBindingSource.Filter = string.Format("DoctorFullName LIKE '%{0}%'", filterText);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _SelectAndClose();
        }

        private void dgvVisits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _SelectAndClose();
            }
        }

        private void _SelectAndClose()
        {
            // 5. قراءة السطر الحالي المختار من خلال الـ BindingSource بأمان وسرعة وبدون تجميد الواجهة
            if (_visitsBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)_visitsBindingSource.Current;

                PatientVisitId = Convert.ToInt32(currentRow["VisitId"]);
                DoctorName = Convert.ToString(currentRow["DoctorFullName"]);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار زيارة من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // حماية الإدخال: السماح بالحروف والمسافات فقط بما أن البحث يتم بالاسم
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}