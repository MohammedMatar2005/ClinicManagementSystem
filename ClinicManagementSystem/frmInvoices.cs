using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using ClinicBusiness.Services;
using ClinicBusiness.DTO.InvoicesDTOs;
using ClinicDataAccess.Data;
using ClinicDataAccess.Repositories;
using ClinicManagementSystem.Appointments;
using ClinicBusiness.DTO.PatientVisitsDTOs;
using ClinicBusiness.DTO.PaitentVisitsDTOs;

namespace ClinicManagementSystem
{
    public partial class frmInvoices : Form
    {
        private readonly clsInvoice _invoiceService;
        private readonly clsPatientVisit _patientVisitService;
        private DataView _invoicesDataView = new DataView();

        private int _selectedPatientId = -1;

        public frmInvoices()
        {
            InitializeComponent();

            var context = new ClinicManagementSystemContext();
            var invoiceRepo = new InvoiceRepository(context);
            var patientVisitRepo = new PatientVisitRepository(context);

            _invoiceService = new clsInvoice(invoiceRepo, patientVisitRepo);
            _patientVisitService = new clsPatientVisit(patientVisitRepo);
        }

        private async void frmInvoices_Load(object sender, EventArgs e)
        {
            ConfigureGridMapping();

            await LoadInvoicesDataAsync();
        }

        private void ConfigureGridMapping()
        {
            dgvInvoices.AutoGenerateColumns = false;

            colInvoiceId.DataPropertyName = "InvoiceId";
            colPatientName.DataPropertyName = "PatientFullName";
       //     colPatientNationalNumber.DataPropertyName = "PatientNationalNumber";
            colFinalAmount.DataPropertyName = "TotalAmount";
            colInvoiceDate.DataPropertyName = "InvoiceDate";
            colInvoiceNumber.DataPropertyName = "InvoiceNumber";
        }

        private async Task LoadInvoicesDataAsync()
        {
            try
            {
                // 1. جلب قائمة الفواتير كاملة لمرة واحدة من الـ Business Layer
                List<InvoiceViewDTO> invoicesList = await _invoiceService.GetAllInvoicesAsync();


                DataTable dt = new DataTable();
                dt.Columns.Add("InvoiceId", typeof(int));
                dt.Columns.Add("VisitId", typeof(int));
                dt.Columns.Add("PatientFullName", typeof(string));
              //  dt.Columns.Add("PatientNationalNumber", typeof(string));
                dt.Columns.Add("InvoiceDate", typeof(DateTime));
                dt.Columns.Add("DueDate", typeof(DateOnly));
                dt.Columns.Add("TotalAmount", typeof(decimal));
                dt.Columns.Add("InvoiceNumber", typeof(string));

                foreach (var item in invoicesList)
                {
                    dt.Rows.Add(
                        item.InvoiceId,
                        item.VisitId,
                        item.PatientFullName,
                        item.InvoiceDate,
                        item.DueDate,
                        item.FinalAmount,
                        item.InvoiceNumber
                    );
                }

                // 3. إسناد الـ DefaultView للمتغير العام وربطه بالواجهة
                _invoicesDataView = dt.DefaultView;
                dgvInvoices.DataSource = _invoicesDataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب الفواتير من السيرفر: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preventLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            // منع إدخال الحروف في خانات الأرقام
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void btnChoosePatient_Click(object sender, EventArgs e)
        {
            // فتح شاشة الاختيار التي صممتها بشكل منبثق آمن
            using (frmChoosePatient frm = new frmChoosePatient())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // 🎯 قراءة المعرف بناءً على الخصائص المحدثة بالريبو باترن
                    _selectedPatientId = frm.PatientId;

                    // إسناد رقم المريض للتكست بوكس الخاص به لتثبيته في الواجهة
                    txtPatientId.Text = _selectedPatientId.ToString();

                    await LoadPatientVisitsAsync(_selectedPatientId);
                }
            }
        }

        private async Task LoadPatientVisitsAsync(int patientId)
        {
            try
            {
                // تنظيف الكومبوبوكس الخاص بالزيارات أولاً قبل التعبئة الجديدة
                cmbVisit.DataSource = null;
                cmbVisit.Items.Clear();

                // جلب قائمة الزيارات الخاصة بالمريض من الـ Business Layer
                // ملاحظة: تأكد من اسم الدالة في الـ Service لديك (مثلاً _visitService أو من خلال الـ _invoiceService)
                List<ChoosePatientVisitDTO> visitsList = await _patientVisitService.GetAllVisitsByPatientId(patientId);

                if (visitsList == null || visitsList.Count == 0)
                {
                    cmbVisit.Items.Add("لا توجد زيارات سابقة لهذا المريض");
                    cmbVisit.SelectedIndex = 0;
                    return;
                }

                // ربط البيانات بالـ ComboBox الذكي
                // العرض (DisplayMember) يظهر للمستخدم تاريخ الزارة أو المعرف، والقيمة (ValueMember) تحمل الـ VisitId
                cmbVisit.DataSource = visitsList;
                cmbVisit.DisplayMember = "VisitDisplayInfo"; // خاصية في الـ DTO تجمع مثلاً (رقم الزيارة - التاريخ)
                cmbVisit.ValueMember = "VisitId";

                // جعل خيار الاختيار الافتراضي هو أول زيارة
                if (cmbVisit.Items.Count > 0)
                    cmbVisit.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب زيارات المريض: {ex.Message}", "خطأ في الزيارات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //    // التحقق من أن الموظف قام باختيار مريض فعلاً لحماية قاعدة البيانات
            //    if (_selectedPatientId == -1)
            //    {
            //        MessageBox.Show("الرجاء اختيار مريض أولاً لإصدار الفاتورة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // التحقق من إدخال المبلغ الإجمالي للفاتورة وتفادي الأخطاء المدخلة
            //    if (!decimal.TryParse(txtTotalAmount.Text.Trim(), out decimal totalAmount) || totalAmount <= 0)
            //    {
            //        MessageBox.Show("الرجاء إدخال مبلغ صحيح للفاتورة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // بناء كائن الحفظ الـ DTO الخاص بالفواتير
            //    var invoice = new InvoiceSaveDto
            //    {
            //        PatientId = _selectedPatientId,
            //        TotalAmount = totalAmount,
            //        InvoiceDate = dtpInvoiceDate.Value,
            //        DueDate = dtpDueDate.Value, // تم تفعيل تاريخ الاستحقاق
            //        Notes = txtNotes.Text.Trim()
            //    };

            //    // حفظ الفاتورة بشكل غير متزامن لمنع تجمد الـ UI
            //    int newInvoiceId = await _invoiceService.AddNewInvoiceAsync(invoice);

            //    if (newInvoiceId > 0)
            //    {
            //        MessageBox.Show("تم حفظ الفاتورة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ClearAllFields();

            //        // تحديث الـ Grid فوراً بسحب البيانات الجديدة
            //        await LoadInvoicesDataAsync();
            //    }
            //    else
            //    {
            //        MessageBox.Show("حدث خطأ أثناء حفظ الفاتورة. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //
        }

        private void ClearAllFields()
        {
            txtSearchValue.Clear();
            _invoicesDataView.RowFilter = string.Empty;

            txtPatientId.Clear();
            _selectedPatientId = -1;

            // إعادة تصفير عناصر التواريخ للوقت الحالي إن وجد

            dtpDueDate.Value = DateTime.Now.AddDays(7); // على سبيل المثال أسبوع كافتراضي للاستحقاق
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            // تنظيف النص المدخل وحمايته من علامات الاقتباس لمنع الأخطاء في الفلترة المحلية
            string searchValue = txtSearchValue.Text.Trim().Replace("'", "''");

            // إذا كانت خانة البحث فارغة، قم بإلغاء الفلتر وعرض جميع الفواتير فوراً
            if (string.IsNullOrEmpty(searchValue))
            {
                _invoicesDataView.RowFilter = string.Empty;
                return;
            }

            try
            {
                // الفلترة اللحظية الذكية بناءً على عمود الرقم الوطني للمريض
                _invoicesDataView.RowFilter = $"PatientNationalNumber LIKE '%{searchValue}%'";
            }
            catch (Exception ex)
            {
                // طباعة الخطأ في شاشة الـ Output للمطور في بيئة الـ Debugging دون تعطيل المستخدم
                System.Diagnostics.Debug.WriteLine($"خطأ أثناء الفلترة بالرقم الوطني: {ex.Message}");
            }
        }

        // 1. زر تصدير كافة الفواتير كجدول شامل (كل الفواتير)
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            // أمان: التحقق من وجود بيانات في الذاكرة قبل فتح نافذة الحفظ
            // ملاحظة: استبدل _invoicesList بالمتغير أو المصدر الذي يحتوي على قائمة الـ DTO لديك (مثل الـ List الأصلية)
            if (_invoicesDataView == null || _invoicesDataView.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات فواتير حالية لتصديرها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = $"تقرير_الفواتير_الشامل_{DateTime.Now:yyyyMMdd}";
                sfd.Title = "حفظ تقرير الفواتير الشامل بصيغة PDF";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // تحويل الـ DataView المفلتر حالياً إلى القائمة الأصلية المتوافقة مع دالة التصدير
                        // لكي يتم طباعة فقط ما هو ظاهر أمام المستخدم على الشاشة (حتى لو كان مفلتراً بالرقم الوطني)
                        List<InvoiceViewDTO> filteredList = new List<InvoiceViewDTO>();

                        foreach (DataRowView rowView in _invoicesDataView)
                        {
                            DataRow row = rowView.Row;
                            filteredList.Add(new InvoiceViewDTO
                            {
                                InvoiceId = Convert.ToInt32(row["InvoiceId"]),
                                PatientFullName = row["PatientFullName"].ToString(),
                               // PatientNationalNumber = row["PatientNationalNumber"].ToString(),
                                FinalAmount = Convert.ToDecimal(row["TotalAmount"]),
                                InvoiceDate = Convert.ToDateTime(row["InvoiceDate"]),
                                InvoiceNumber = row["InvoiceNumber"].ToString()
                            });
                        }

                        // استدعاء الدالة الإجمالية من كلاس التصدير وتمرير المسار المختبر
                        ClinicBusiness.Utils.ExportPDF.GenerateAllInvoicesTablePDF(filteredList, sfd.FileName);

                        MessageBox.Show("تم تصدير التقرير الجدول الشامل بنجاح!", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"حدث خطأ أثناء حفظ ملف التقرير الشامل: {ex.Message}", "خطأ في التصدير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 2. زر تصدير فاتورة واحدة تفصيلية للمريض المحدد (فاتورة واحدة)
        private void btnExportThisInvoice_Click(object sender, EventArgs e)
        {
            // أمان: التأكد من أن الموظف قام بتحديد سطر (فاتورة) من الجدول أولاً
            if (dgvInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد الفاتورة المراد تصديرها من الجدول أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // جلب السطر المحدد حالياً في الـ DataGridView
                var selectedRow = dgvInvoices.SelectedRows[0];

                // بناء كائن DTO مؤقت سريع من السطر المختار لتمريره مباشرة لدالة الفاتورة الفردية
                // (إذا كانت بقية تفاصيل الرسوم مثل الكشفية والمختبر غير مربوطة بالجدول، يفضل جلب الـ DTO كامل من الـ Service بواسطة الـ InvoiceId)
                InvoiceViewDTO selectedInvoice = new InvoiceViewDTO
                {
                    InvoiceId = Convert.ToInt32(selectedRow.Cells["colInvoiceId"].Value),
                    InvoiceNumber = selectedRow.Cells["colInvoiceNumber"].Value?.ToString(),
                    PatientFullName = selectedRow.Cells["colPatientName"].Value?.ToString(),
                    //PatientNationalNumber = selectedRow.Cells["colPatientNationalNumber"].Value?.ToString(),
                    FinalAmount = Convert.ToDecimal(selectedRow.Cells["colFinalAmount"].Value),
                    InvoiceDate = Convert.ToDateTime(selectedRow.Cells["colInvoiceDate"].Value),

                    // في حال رغبت بملء حقول الرسوم التفصيلية للفاتورة الفردية بدقة كاملة:
                    // يمكنك فك الحظر عن السطر بالأسفل واستدعاء الـ Service فوراً:
                    // SelectedInvoice = await _invoiceService.GetInvoiceDetailsForPdfAsync(invoiceId);
                };

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.FileName = $"فاتورة_{selectedInvoice.InvoiceNumber}_{selectedInvoice.PatientFullName.Replace(" ", "_")}";
                    sfd.Title = "حفظ الفاتورة التفصيلية بصيغة PDF";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // استدعاء الدالة الفردية من كلاس التصدير وتمرير المسار
                        ClinicBusiness.Utils.ExportPDF.GenerateSingleInvoicePDF(selectedInvoice, sfd.FileName);

                        MessageBox.Show("تم تصدير الفاتورة التفصيلية للمريض بنجاح!", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تصدير الفاتورة الفردية: {ex.Message}", "خطأ في التصدير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}