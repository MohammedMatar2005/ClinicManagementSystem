using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using ClinicBusiness.Models;

namespace ClinicManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>  
        [STAThread]
        static void Main()
        {
            var context = new ClinicManagementSystemContext();

            // 2. إنشاء الخدمات وتمرير الـ context لها يدوياً في الباني
            var patientVisitService = new clsPatientVisit(context);
            var invoiceService = new clsInvoice(context);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());


          
        }
    }
}