using ClinicBusiness.DTO.InvoicesDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicBusiness.Utils;
using ClinicManagementSystem.Finance;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicManagementSystem.Invoices
{
    public partial class frmChooseInvoice : Form
    {
        // BindingSource على مستوى الكلاس لتفعيل الفلترة السريعة أثناء البحث
        private BindingSource _invoicesBindingSource = new BindingSource();
        private clsInvoice _invoiceService;
        private clsPatientVisit _visitsService;
        private readonly ClinicManagementSystemContext _context;


        public int InvoiceId { get; private set; }
        public string InvoiceNumber { get; private set; }
        public string PatientName { get; private set; }
        public decimal TotalAmount { get; private set; }
        public decimal RemainingAmount { get; private set; }

        public frmChooseInvoice()
        {
            InitializeComponent();
            _context = new ClinicManagementSystemContext();

            _invoiceService = new clsInvoice(_context);
            _visitsService = new clsPatientVisit(_context);
        }

        private void frmChooseInvoice_Load(object sender, EventArgs e)
        {
            _ConfigureDataGridView();
            _LoadAllInvoices();

            txtSearch.ForeColor = System.Drawing.Color.Black;
        }

        private void _ConfigureDataGridView()
        {
            dgvInvoices.AutoGenerateColumns = false;

            // 1. معرف الفاتورة (العمود الأول من اليمين)
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InvoiceId",
                HeaderText = "معرف الفاتورة",
                DataPropertyName = "InvoiceId"
            });

            // 2. رقم الفاتورة
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InvoiceNumber",
                HeaderText = "رقم الفاتورة",
                DataPropertyName = "InvoiceNumber"
            });

            // 3. اسم المريض
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PatientFullName",
                HeaderText = "اسم المريض",
                DataPropertyName = "PatientFullName"
            });

            // 4. الرقم الوطني
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PatientNationalNumber",
                HeaderText = "الرقم الوطني",
                DataPropertyName = "PatientNationalNumber"
            });

            // 5. تاريخ الفاتورة
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InvoiceDate",
                HeaderText = "تاريخ الفاتورة",
                DataPropertyName = "InvoiceDate"
            });

            // 6. الإجمالي (تعديل الـ DataPropertyName ليطابق القادم من السيرفر: FinalAmount)
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FinalAmount",
                HeaderText = "الإجمالي",
                DataPropertyName = "FinalAmount"
            });

            // 7. المتبقي
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RemainingAmount",
                HeaderText = "المتبقي",
                DataPropertyName = "RemainingAmount"
            });

            // 8. حالة السداد (تعديل الـ Name والـ DataPropertyName ليطابق الحسبة الديناميكية: PaymentStatusName)
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaymentStatusName",
                HeaderText = "حالة السداد",
                DataPropertyName = "PaymentStatusName"
            });

            // إعدادات أحجام الأعمدة (تم تعديل الأسماء هنا لتطابق الأعمدة الجديدة وتمنع خطأ الـ NullReferenceException)
            dgvInvoices.Columns["InvoiceId"].Width = 90;
            dgvInvoices.Columns["PatientNationalNumber"].Width = 110;
            dgvInvoices.Columns["PaymentStatusName"].Width = 110;

            // ربط حدث التلوين أو التنسيق
            dgvInvoices.CellFormatting += dgvInvoices_CellFormatting;
        }
        private async void _LoadAllInvoices()
        {
            try
            {
                clsInvoice invoiceService = new clsInvoice(_context);
                var invoicesList = await invoiceService.GetAllInvoicesAsync();

                if (invoicesList != null)
                {
                    // تحويل الـ List إلى DataTable لتفعيل ميزة الـ Filter داخل الـ BindingSource
                    DataTable dtInvoices = ConvertToDataTable._ConvertToDataTable(invoicesList);

                    _invoicesBindingSource.DataSource = dtInvoices;

                    dgvInvoices.DataSource = _invoicesBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الفواتير: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_invoicesBindingSource.DataSource == null) return;
            if (txtSearch.Text == "🔍 أدخل اسم المريض أو رقم الفاتورة للبحث...") return;

            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText))
            {
                _invoicesBindingSource.RemoveFilter();
                return;
            }

            _invoicesBindingSource.Filter = string.Format("PatientFullName LIKE '%{0}%' OR InvoiceNumber LIKE '%{0}%'", filterText);
        }

        // تلوين خلية "حالة السداد": أحمر لغير مدفوعة، برتقالي لمدفوعة جزئياً، أخضر لمدفوعة بالكامل
        private void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInvoices.Columns[e.ColumnIndex].Name != "StatusTitle" || e.Value == null) return;

            string status = e.Value.ToString();

            if (status == "غير مدفوعة")
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
                e.CellStyle.Font = new System.Drawing.Font(dgvInvoices.Font, System.Drawing.FontStyle.Bold);
            }
            else if (status == "مدفوعة جزئياً")
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
                e.CellStyle.Font = new System.Drawing.Font(dgvInvoices.Font, System.Drawing.FontStyle.Bold);
            }
            else if (status == "مدفوعة بالكامل")
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
                e.CellStyle.Font = new System.Drawing.Font(dgvInvoices.Font, System.Drawing.FontStyle.Bold);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _SelectAndClose();
        }

        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _SelectAndClose();
        }

        private void _SelectAndClose()
        {
            if (_invoicesBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)_invoicesBindingSource.Current;

                InvoiceId = Convert.ToInt32(currentRow["InvoiceId"]);
                InvoiceNumber = Convert.ToString(currentRow["InvoiceNumber"]);
                PatientName = Convert.ToString(currentRow["PatientFullName"]);
                TotalAmount = Convert.ToDecimal(currentRow["TotalAmount"]);
                RemainingAmount = Convert.ToDecimal(currentRow["RemainingAmount"]);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار فاتورة من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewInvoice_Click(object sender, EventArgs e)
        {
            //using (frmInvoices frm = new frmInvoices())
            //{
            //    frm.ShowDialog();
            //}
        }

        private void toolStripShowInvoiceInfo_Click(object sender, EventArgs e)
        {
            //int _selectedInvoiceId = 0;

            //_selectedInvoiceId = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceId"].Value);

            //using (frmShowInvoiceInfo frm = new frmShowInvoiceInfo(_selectedInvoiceId))
            //{
            //    frm.ShowDialog();
            //}
        }

        private void toolStripUpdateInvoice_Click(object sender, EventArgs e)
        {
            //int _selectedInvoiceId = 0;

            //_selectedInvoiceId = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceId"].Value);

            //using (frmUpdateInvoice frm = new frmUpdateInvoice(_selectedInvoiceId))
            //{
            //    frm.ShowDialog();
            //}
        }




        private void toolStripShowInvoiceInfo_Click_1(object sender, EventArgs e)
        {
            int invoiceId = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceId"].Value);

            using (frmShowInvoiceInfo frm = new frmShowInvoiceInfo(invoiceId))
            {
                frm.ShowDialog();
            }
        }

        private void toolStripAddNewInvoice_Click_1(object sender, EventArgs e)
        {
            using (frmInvoices frm = new frmInvoices(_invoiceService, _visitsService))
            {
                frm.ShowDialog();
            }
        }

        private async void toolStripDeleteInvoice_Click_1(object sender, EventArgs e)
        {
            int invoiceId = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceId"].Value);

            DialogResult result = MessageBox.Show(
                $"هل أنت متأكد من رغبتك في حذف الفاتورة رقم ({invoiceId}) بشكل نهائي؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = await _invoiceService.DeleteInvoiceAsync(invoiceId);
                if (isDeleted)
                {
                    MessageBox.Show("تم حذف الفاتورة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadAllInvoices();
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء حذف الفاتورة. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripUpdateInvoice_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow != null)
            {
                // جلب قيمة الـ Id من العمود المخصص له في السطر المحدد
                InvoiceId = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceId"].Value);

                // تحديد نتيجة الفورم على أنها OK لإعلام الفورم الأصلي بالنجاح
                this.DialogResult = DialogResult.OK;

                // إغلاق الفورم الحالي تلقائياً
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار فاتورة أولاً.");
            }
        }
    }
}