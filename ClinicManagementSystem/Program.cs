using ClinicBusiness.DTO.UsersDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using ClinicManagementSystem.Finance;
using ClinicManagementSystem.Invoices;

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
            var paymentServcie = new clsPayment(context);

            LoginRequestDTO loggedUser = new LoginRequestDTO { Username = "MM11MM",
                Password = "MMM111MMM"
            };
        

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());


          
        }
    }
}