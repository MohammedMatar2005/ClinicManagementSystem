using ClinicBusiness.DTO.InvoicesDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicBusiness.Utils;
using ClinicManagementSystem.Finance;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Invoices
{
    public partial class frmChooseInvoice : Form
    {
        private BindingSource _invoicesBindingSource = new BindingSource();
        private readonly clsInvoice _invoiceService;
        private readonly clsPatientVisit _visitsService;
        private readonly ClinicManagementSystemContext _context;

        public int InvoiceId { get; private set; } = -1;
        public string InvoiceNumber { get; private set; } = string.Empty;
        public string PatientName { get; private set; } = string.Empty;
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
            cmbSearchType.SelectedIndex = 0; // "بلا" كإعداد افتراضي
            _LoadAllInvoices();
        }

        private void _ConfigureDataGridView()
        {
            dgvInvoices.AutoGenerateColumns = false;
            dgvInvoices.Columns.Clear();

            // 1. معرف الفاتورة
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

            // 6. الإجمالي
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

            // 8. حالة السداد
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaymentStatusName",
                HeaderText = "حالة السداد",
                DataPropertyName = "PaymentStatusName"
            });

            // قياسات العرض للأعمدة
            dgvInvoices.Columns["InvoiceId"].Width = 90;
            dgvInvoices.Columns["PatientNationalNumber"].Width = 110;
            dgvInvoices.Columns["PaymentStatusName"].Width = 110;

            // تلوين خانات حالة السداد
            dgvInvoices.CellFormatting += dgvInvoices_CellFormatting;
        }

        private async void _LoadAllInvoices()
        {
            try
            {
                var invoicesList = await _invoiceService.GetAllInvoicesAsync();

                if (invoicesList != null)
                {
                    // استخدام المحول لاستبدال القائمة بـ DataTable مجهزة لسرعة الفلترة داخل الذاكرة
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

        private void ClearAllFields()
        {
            txtSearch.Text = string.Empty;
            _invoicesBindingSource.RemoveFilter();
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
            // السماح بالأرقام فقط في الحقول الرقمية الصريحة المقيدة (مثل معرف الفاتورة)
            if (cmbSearchType.Text == "معرف الفاتورة")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_invoicesBindingSource.DataSource == null) return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(searchValue) || cmbSearchType.Text == "بلا")
            {
                _invoicesBindingSource.RemoveFilter();
                return;
            }

            switch (cmbSearchType.Text)
            {
                case "معرف الفاتورة":
                    if (int.TryParse(searchValue, out int id))
                    {
                        _invoicesBindingSource.Filter = $"InvoiceId = {id}";
                    }
                    else
                    {
                        _invoicesBindingSource.RemoveFilter();
                    }
                    break;

                case "رقم الفاتورة":
                    _invoicesBindingSource.Filter = $"InvoiceNumber LIKE '%{searchValue}%'";
                    break;

                case "اسم المريض":
                    _invoicesBindingSource.Filter = $"PatientFullName LIKE '%{searchValue}%'";
                    break;

                case "الرقم الوطني":
                    _invoicesBindingSource.Filter = $"PatientNationalNumber LIKE '%{searchValue}%'";
                    break;

                case "حالة السداد":
                    _invoicesBindingSource.Filter = $"PaymentStatusName LIKE '%{searchValue}%'";
                    break;

                default:
                    _invoicesBindingSource.RemoveFilter();
                    break;
            }
        }

        private void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInvoices.Columns[e.ColumnIndex].Name != "PaymentStatusName" || e.Value == null) return;

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

        private void _SelectAndClose()
        {
            if (_invoicesBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)_invoicesBindingSource.Current;

                InvoiceId = Convert.ToInt32(currentRow["InvoiceId"]);
                InvoiceNumber = Convert.ToString(currentRow["InvoiceNumber"]);
                PatientName = Convert.ToString(currentRow["PatientFullName"]);
                TotalAmount = Convert.ToDecimal(currentRow["FinalAmount"]);
                RemainingAmount = Convert.ToDecimal(currentRow["RemainingAmount"]);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار فاتورة من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _SelectAndClose();
        }

        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                _SelectAndClose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolStripShowInvoiceInfo_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow == null) return;

            int invoiceId = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceId"].Value);

            using (frmShowInvoiceInfo frm = new frmShowInvoiceInfo(invoiceId))
            {
                frm.ShowDialog();
            }
        }

        private void toolStripAddNewInvoice_Click(object sender, EventArgs e)
        {
            using (frmInvoices frm = new frmInvoices(_invoiceService, _visitsService))
            {
                frm.ShowDialog();
            }

            _LoadAllInvoices();
        }

        private async void toolStripDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow == null) return;

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

        private void toolStripUpdateInvoice_Click(object sender, EventArgs e)
        {
            int invoiceId = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceId"].Value);

            using (frmShowInvoiceInfo frm = new frmShowInvoiceInfo(invoiceId))
            {
                
                frm.ShowDialog();
            }
        }

        private void btnAddNewInvoice_Click(object sender, EventArgs e)
        {
            using (frmInvoices frm = new frmInvoices(_invoiceService, _visitsService))
            {
                frm.ShowDialog();
            }

            _LoadAllInvoices();
        }
    }
}