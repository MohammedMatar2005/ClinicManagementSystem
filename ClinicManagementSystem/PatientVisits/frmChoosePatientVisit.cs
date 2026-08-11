using ClinicBusiness.Services;
using ClinicBusiness.Models; // الاعتماد على الموديلز الموحدة للبزنس
using ClinicBusiness.DTO.PatientVisitsDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.PatientVisits;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChoosePatientVisit : Form
    {
        // 1. استخدام الـ BindingSource للتحكم بالعرض، مربوط مباشرة بـ List<PatientVisitViewDTO>
        //    (بدون تحويل وسيط لـ DataTable كما كان سابقاً، للحفاظ على الأنواع القوية Type-Safety)
        private BindingSource _visitsBindingSource = new BindingSource();
        private readonly ClinicManagementSystemContext _context;

        private clsPatientVisit _patientVisitService;

        // نحتفظ بالقائمة الكاملة الأصلية بذاكرة البرنامج لتطبيق الفلترة عليها يدوياً عند البحث
        private List<PatientVisitViewDTO> _originalVisitsList = new List<PatientVisitViewDTO>();

        // خصائص عامة لقراءة البيانات من فورم المواعيد بعد الإغلاق
        public int PatientVisitId { get; private set; } = -1;
        public string DoctorName { get; private set; } = string.Empty;

        private readonly int _patientId;

        public frmChoosePatientVisit()
        {
            InitializeComponent();

            // حقن الـ Context مباشرة للفورم
            _context = new ClinicManagementSystemContext();
            _patientVisitService = new clsPatientVisit(_context);
        }

        private async void frmChoosePatientVisit_Load(object sender, EventArgs e)
        {
            dgvVisits.AutoGenerateColumns = false;

            _BuildGridColumnsStructure();
            await _LoadAllVisitsAsync();

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
                Width = 80
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
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DoctorFullName",
                DataPropertyName = "DoctorFullName",
                HeaderText = "اسم الطبيب المعالج",
                Width = 180
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AppointmentReason",
                DataPropertyName = "AppointmentReason",
                HeaderText = "سبب الموعد",
                Width = 160
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Diagnosis",
                DataPropertyName = "Diagnosis",
                HeaderText = "التشخيص الطبي",
                Width = 200
            });

            // العمود الجديد: حالة الزيارة (موجود بالـ DTO الجديد ولم يكن معروضاً سابقاً)
            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VisitStatusTitle",
                DataPropertyName = "VisitStatusTitle",
                HeaderText = "حالة الزيارة",
                Width = 110
            });
        }

        /// <summary>
        /// جلب كل الزيارات (بدل الزيارات غير المفوترة فقط سابقاً) وربطها مباشرة بالـ GridView
        /// عبر BindingSource بدون تحويل لـ DataTable.
        /// </summary>
        private async Task _LoadAllVisitsAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _originalVisitsList = await _patientVisitService.GetAllPatientVisitsAsync();

                _visitsBindingSource.DataSource = _originalVisitsList;
                dgvVisits.DataSource = _visitsBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الزيارات: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(filterText))
            {
                // إعادة القائمة الكاملة بدون فلترة
                _visitsBindingSource.DataSource = _originalVisitsList;
                return;
            }

            // فلترة يدوية بالذاكرة على اسم الطبيب أو اسم المريض
            // (List<T> لا يدعم BindingSource.Filter مباشرة كما كان يدعمه DataTable، لذلك نفلتر يدوياً)
            var filtered = _originalVisitsList
                .Where(v =>
                    (v.DoctorFullName != null && v.DoctorFullName.Contains(filterText, StringComparison.OrdinalIgnoreCase)) ||
                    (v.PatientFullName != null && v.PatientFullName.Contains(filterText, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            _visitsBindingSource.DataSource = filtered;
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
            // قراءة السطر الحالي المختار مباشرة كـ PatientVisitViewDTO (Type-Safe بدون Convert)
            if (_visitsBindingSource.Current is PatientVisitViewDTO currentVisit)
            {
                PatientVisitId = currentVisit.VisitId;
                DoctorName = currentVisit.DoctorFullName;

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

        private void tsmiAddNewPatientVisit_Click_1(object sender, EventArgs e)
        {
            using (Form frm = new frmAddUpdatePatinetVisits(_patientVisitService))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _ = _LoadAllVisitsAsync(); // إعادة تحميل القائمة بعد الإضافة
                }
            }
        }

        private void tsmiViewPatientVisitDetails_Click(object sender, EventArgs e)
        {
            if (!(dgvVisits.CurrentRow?.DataBoundItem is PatientVisitViewDTO selectedVisit))
            {
                MessageBox.Show("الرجاء اختيار زيارة من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Form frm = new frmShowPatientVisitInfo(selectedVisit.VisitId))
            {
                frm.ShowDialog();
            }
        }

        private async void tsmiDeletePatientVisit_Click(object sender, EventArgs e)
        {
            if (!(dgvVisits.CurrentRow?.DataBoundItem is PatientVisitViewDTO selectedVisit))
            {
                MessageBox.Show("الرجاء اختيار زيارة من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف زيارة هذا المريض؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = await _patientVisitService.DeletePatientVisitAsync(selectedVisit.VisitId);

                if (isDeleted)
                {
                    MessageBox.Show("تم حذف زيارة المريض بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await _LoadAllVisitsAsync(); // إعادة تحميل البيانات بعد الحذف
                }
                else
                {
                    MessageBox.Show("فشلت عملية الحذف، قد يكون المريض مرتبطاً ببيانات أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiUpdatePatientVisitInfo_Click(object sender, EventArgs e)
        {
            if (!(dgvVisits.CurrentRow?.DataBoundItem is PatientVisitViewDTO selectedVisit))
            {
                MessageBox.Show("الرجاء اختيار زيارة من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Form frm = new frmUpdatePatientVisitInfo(selectedVisit.VisitId))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _ = _LoadAllVisitsAsync(); // إعادة تحميل القائمة بعد التعديل
                }
            }
        }
    }
}