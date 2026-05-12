using Microsoft.Win32;
using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;
using ClinicManagementApplication.Infrastructure;
using ClinicBusiness;



namespace ClinicManagementApplication.ViewModels
{
    public class InvoicesViewModel : BaseViewModel
    {
        private static readonly Random _random = new Random();

        // ====== المجموعات (Collections) ======

        // سجل الفواتير السابقة للجدول الكبير
        private ObservableCollection<clsInvoice> _allInvoicesList = new ObservableCollection<clsInvoice>();
        public ObservableCollection<clsInvoice> Invoices
        {
            get => _allInvoicesList;
            set { _allInvoicesList = value; OnPropertyChanged(); }
        }

        // قائمة المرضى للـ ComboBox
        public ObservableCollection<clsPatient> Patients { get; set; } = new ObservableCollection<clsPatient>();

        // ====== الفاتورة الحالية (تحت الإنشاء) ======

        private clsInvoice _selectedInvoice;
        public clsInvoice SelectedInvoice
        {
            get => _selectedInvoice;
            set { _selectedInvoice = value; OnPropertyChanged(); }
        }


        private int _selectedPatientId;
        public int SelectedPatientId
        {
            get => _selectedPatientId;
            set
            {
                _selectedPatientId = value;
                OnPropertyChanged();
                // بمجرد اختيار المريض، نقوم بتحميل زياراته
                _ = LoadPatientVisits(value);
            }
        }

        private ObservableCollection<clsPatientVisit> _patientVisits;
        public ObservableCollection<clsPatientVisit> PatientVisits
        {
            get => _patientVisits;
            set { _patientVisits = value; OnPropertyChanged(); }
        }

        private int _selectedVisitId;
        public int SelectedVisitId
        {
            get => _selectedVisitId;
            set
            {
                _selectedVisitId = value;
                SelectedInvoice.VisitId = value; // ربط الزيارة بالمودل
                OnPropertyChanged();

                // AutoFillFeesFromVisit(value);
            }
        }

        public bool IsVisitSelectionEnabled => SelectedPatientId > 0;

        private async Task LoadPatientVisits(int patientId)
        {
            // استعلام لجلب الزيارات التي ليس لها فواتير لهذا المريض
            //var visits = await Task.Run(() => clsPatientVisit.GetUninvoicedVisitsByPatient(patientId));
            //PatientVisits = new ObservableCollection<clsPatientVisit>(visits);
        }

        // ====== خصائص الحسابات (Calculations) ======

        // ====== خصائص الحسابات (مطابقة تماماً للمودل) ======

        public decimal ConsultationFee
        {
            get => SelectedInvoice.ConsultationFee;
            set { SelectedInvoice.ConsultationFee = value; UpdateTotals(); OnPropertyChanged(); }
        }

        public decimal LabTestFee
        {
            get => SelectedInvoice.LabTestFee;
            set { SelectedInvoice.LabTestFee = value; UpdateTotals(); OnPropertyChanged(); }
        }

        public decimal ProcedureFee
        {
            get => SelectedInvoice.ProcedureFee;
            set { SelectedInvoice.ProcedureFee = value; UpdateTotals(); OnPropertyChanged(); }
        }

        public decimal OtherCharges
        {
            get => SelectedInvoice.OtherCharges;
            set { SelectedInvoice.OtherCharges = value; UpdateTotals(); OnPropertyChanged(); }
        }

        public decimal DiscountPercentage
        {
            get => SelectedInvoice.DiscountPercentage;
            set { SelectedInvoice.DiscountPercentage = value; UpdateTotals(); OnPropertyChanged(); }
        }

        public decimal TaxPercentage
        {
            get => SelectedInvoice.TaxPercentage;
            set { SelectedInvoice.TaxPercentage = value; UpdateTotals(); OnPropertyChanged(); }
        }

        // الخصائص المحسوبة (Read-only في الواجهة)
        public decimal SubTotal => SelectedInvoice.SubTotal;
        public decimal DiscountAmount => SelectedInvoice.DiscountAmount;
        public decimal TaxAmount => SelectedInvoice.TaxAmount;
        public decimal FinalAmount => SelectedInvoice.FinalAmount;

        // ====== الأوامر (Commands) ======
        public ICommand SaveCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand ExportToPdfCommand { get; }
        public ICommand PrintInvoiceCommand { get; } // لطباعة فاتورة محددة من الجدول

        public InvoicesViewModel()
        {
            // تهيئة فاتورة جديدة فارغة عند التشغيل
            PrepareNewInvoice();

            SaveCommand = new RelayCommand(async _ => await SaveInvoice());
            ClearCommand = new RelayCommand(_ => PrepareNewInvoice());
            ExportToPdfCommand = new RelayCommand(_ => ExportAllToPdf());
            // PrintInvoiceCommand = new RelayCommand(param => PrintSingleInvoice(param as clsInvoice));

            _ = LoadData();
        }

        // ====== الميثودات (Methods) ======

        private void PrepareNewInvoice()
        {
            SelectedInvoice = new clsInvoice
            {
                InvoiceNumber = GenerateInvoiceNumber(),
                InvoiceDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                IsActive = true
            };
            // إعادة تصفير الحقول في الواجهة
            OnPropertyChanged(string.Empty);
        }

        private string GenerateInvoiceNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        private void UpdateTotals()
        {
            // 1. حساب المجموع الفرعي
            SelectedInvoice.SubTotal = ConsultationFee + LabTestFee + ProcedureFee + OtherCharges;

            // 2. حساب الخصم
            SelectedInvoice.DiscountAmount = SelectedInvoice.SubTotal * (DiscountPercentage / 100);

            // 3. حساب الضريبة (بعد الخصم أو قبله حسب سياستك، هنا سنحسبها على الصافي)
            decimal afterDiscount = SelectedInvoice.SubTotal - SelectedInvoice.DiscountAmount;
            SelectedInvoice.TaxAmount = afterDiscount * (TaxPercentage / 100);

            // 4. الإجمالي النهائي
            SelectedInvoice.FinalAmount = afterDiscount + SelectedInvoice.TaxAmount;

            // تحديث الواجهة
            OnPropertyChanged(nameof(SubTotal));
            OnPropertyChanged(nameof(DiscountAmount));
            OnPropertyChanged(nameof(TaxAmount));
            OnPropertyChanged(nameof(FinalAmount));
        }

        private async Task LoadData()
        {
            IsLoading = true;
            try
            {
                //  محاكاة// تحميل البيانات من قاعدة البيانات
                Invoices = new ObservableCollection<clsInvoice>(await Task.Run(() => clsInvoice.GetAll().ToObservableCollection<clsInvoice>()));
                //    Patients = new ObservableCollection<clsInvoice>(await Task.Run(() => clsPatient.GetAllPatients()));
            }
            finally { IsLoading = false; }
        }

        private async Task SaveInvoice()
        {
            // منطق الحفظ في قاعدة البيانات
            //MessageBox.Show($"تم حفظ الفاتورة رقم {SelectedInvoice.InvoiceNumber} بنجاح!");
            //Invoices.Add(SelectedInvoice); // إضافة للسجل مؤقتاً
            //PrepareNewInvoice(); // تجهيز الواجهة لفاتورة جديدة
        }






        private void ExportAllToPdf()
        {
            // 1. جلب البيانات من الـ ADO Class الخاص بك
            //var invoices = clsInvoice.GetAllInvoices_Sorted();

            //if (invoices == null || !invoices.Any())
            //{
            //    System.Windows.MessageBox.Show("لا توجد بيانات لتصديرها.");
            //    return;
            //}

            //// 2. إعداد نافذة حفظ الملف
            //var dialog = new SaveFileDialog
            //{
            //    Filter = "PDF Files (*.pdf)|*.pdf",
            //    FileName = "Full_Invoices_Report_" + DateTime.Now.ToString("yyyyMMdd")
            //};

            //if (dialog.ShowDialog() != true) return;

            //// 3. تطبيق رخصة المكتبة (ضروري لتعمل المكتبة)
            //QuestPDF.Settings.License = LicenseType.Community;

            //try
            //{
            //    // 4. إنشاء المستند وحفظه مباشرة
            //    QuestPDF.Fluent.Document.Create(container =>
            //    {
            //        container.Page(page =>
            //        {
            //            // إعدادات الصفحة (عرضي Landscape)
            //            page.Size(PageSizes.A4.Landscape());
            //            page.Margin(1, Unit.Centimetre);
            //            page.PageColor(Colors.White);
            //            page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.SegoeUI));

            //            // الرأس (Header)
            //            page.Header().Row(row =>
            //            {
            //                row.RelativeItem().Column(col =>
            //                {
            //                    col.Item().Text("All Invoices Report").FontSize(22).SemiBold().FontColor(Colors.Blue.Medium);
            //                    col.Item().Text($"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(10).Italic();
            //                });

            //                row.ConstantItem(100).AlignRight().Text(x =>
            //                {
            //                    x.Span("Page ");
            //                    x.CurrentPageNumber();
            //                    x.Span(" / ");
            //                    x.TotalPages();
            //                });
            //            });

            //            // المحتوى (Content)
            //            page.Content().PaddingVertical(10).Table(table =>
            //            {
            //                // تعريف الـ 6 أعمدة ونسب عرضها
            //                table.ColumnsDefinition(columns =>
            //                {
            //                    columns.ConstantColumn(35);  // #
            //                    columns.RelativeColumn(2);   // Invoice No
            //                    columns.RelativeColumn(3);   // Patient Name
            //                    columns.RelativeColumn(2);   // Date
            //                    columns.RelativeColumn(2);   // Amount
            //                    columns.RelativeColumn(2);   // Status
            //                });

            //                // ترويسة الجدول
            //                table.Header(header =>
            //                {
            //                    header.Cell().Element(HeaderStyle).Text("#");
            //                    header.Cell().Element(HeaderStyle).Text("Invoice No");
            //                    header.Cell().Element(HeaderStyle).Text("Patient");
            //                    header.Cell().Element(HeaderStyle).Text("Date");
            //                    header.Cell().Element(HeaderStyle).Text("Amount");
            //                    header.Cell().Element(HeaderStyle).Text("Status");

            //                    static IContainer HeaderStyle(IContainer c) =>
            //                        c.DefaultTextStyle(x => x.SemiBold().FontColor(Colors.White))
            //                         .PaddingVertical(5).Background(Colors.Grey.Darken3).AlignCenter();
            //                });

            //                // تعبئة الصفوف من البيانات
            //                int i = 1;
            //                foreach (var inv in invoices)
            //                {
            //                    table.Cell().Element(RowStyle).AlignCenter().Text(i++.ToString());
            //                    table.Cell().Element(RowStyle).AlignCenter().Text(inv.InvoiceNumber ?? "N/A");
            //                    table.Cell().Element(RowStyle).Text(inv.FullName ?? "N/A");
            //                    table.Cell().Element(RowStyle).AlignCenter().Text(inv.InvoiceDate.ToString("dd/MM/yyyy"));
            //                    table.Cell().Element(RowStyle).AlignRight().Text($"${inv.FinalAmount:N2} ");

            //                    // تلوين الحالة بناءً على الـ Enum الخاص بك
            //                    // استخدمنا المسار الكامل للون لتجنب أي تعارض
            //                    var statusColor = (inv.Status == clsInvoice.enStatus.Paid)
            //                        ? Colors.Green.Medium
            //                        : Colors.Red.Medium;

            //                    table.Cell().Element(RowStyle).AlignCenter()
            //                         .Text(inv.Status.ToString())
            //                         .FontColor(statusColor)
            //                         .SemiBold();

            //                    static IContainer RowStyle(IContainer c) =>
            //                        c.BorderBottom(1).BorderColor(Colors.Grey.Lighten3).PaddingVertical(5);
            //                }
            //            });

            //            // تذييل الصفحة (Footer)
            //            page.Footer().AlignRight().Text(x =>
            //            {
            //                x.Span("Total Invoices Amount: ").SemiBold();
            //                x.Span($"${invoices.Sum(inv => inv.FinalAmount):N2}").FontColor(Colors.Blue.Medium).SemiBold();
            //            });
            //        });
            //    })
            //    .GeneratePdf(dialog.FileName);

            //    // 5. فتح الملف بعد الانتهاء
            //    Process.Start(new ProcessStartInfo(dialog.FileName) { UseShellExecute = true });
            //}
            //catch (Exception ex)
            //{
            //    System.Windows.MessageBox.Show($"حدث خطأ أثناء التصدير:\n{ex.Message}", "خطأ", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            //}
        }
    }
}