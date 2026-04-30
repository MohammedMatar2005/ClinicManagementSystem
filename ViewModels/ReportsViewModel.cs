using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Input;
using ClinicBusiness;
using ClinicManagementApplication.Infrastructure;

namespace ClinicManagementApplication.ViewModels
{
    public class ReportsViewModel : BaseViewModel
    {
        // 1. القائمة التي ستعرض نتائج التقرير
        // بما أن التقارير قد تختلف أعمدتها، نستخدم DataTable أو كلاس عام
        public ObservableCollection<clsReportRow> ReportData { get; set; } = new ObservableCollection<clsReportRow>();

        // 2. فلاتر البحث (مثلاً تاريخ البداية والنهاية)
        private DateTime _fromDate = DateTime.Now.AddMonths(-1);
        public DateTime FromDate
        {
            get => _fromDate;
            set { _fromDate = value; OnPropertyChanged(); }
        }

        private DateTime _toDate = DateTime.Now;
        public DateTime ToDate
        {
            get => _toDate;
            set { _toDate = value; OnPropertyChanged(); }
        }

        // 3. الأوامر
        public ICommand GenerateReportCommand { get; }
        public ICommand PrintReportCommand { get; }

        public ReportsViewModel()
        {
            GenerateReportCommand = new RelayCommand(async (p) => await LoadReport());
            PrintReportCommand = new RelayCommand((p) => PrintReport());
        }

        private async Task LoadReport()
        {
            //IsLoading = true;
            //try
            //{
            //    // استدعاء دالة التقارير من البزنس لاير
            //    DataTable dt = await Task.Run(() => clsReport.GetFinancialReport(FromDate, ToDate));

            //    ReportData.Clear();
            //    if (dt != null)
            //    {
            //        // تحويل البيانات لكلاس تقرير مخصص
            //        var list = dt.ToList<clsReportRow>();
            //        foreach (var row in list)
            //        {
            //            ReportData.Add(row);
            //        }
            //    }
            //}
            //finally
            //{
            //    IsLoading = false;
            //}
        }

        private void PrintReport()
        {
            // منطق تصدير التقرير لـ PDF أو طباعته
        }
    }

    // كلاس بسيط لتمثيل سطر في التقرير (يجب أن يطابق أعمدة الـ DataTable)
    public class clsReportRow
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}