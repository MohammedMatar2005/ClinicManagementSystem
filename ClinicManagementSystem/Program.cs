using ClinicBusiness.DTO.UsersDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using ClinicManagementSystem.Finance;
using ClinicManagementSystem.Invoices;
using ClinicManagementSystem.PatientVisits;

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
            var loggingService = new clsLoggingService(context);

            UserViewDTO loggedUser = new UserViewDTO
            {
                UserId = 1,
                Username = "MM11MM",
                FullName = "مهندس محمد أحمد",
                RoleName = "Admin",
                IsActive = true,
                CreatedDate = DateTime.Now.AddMonths(-5),
                LastLoginDate = DateTime.Now
            };


                


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize(); 
            Application.Run(new frmLogin());


          
        }
    }
}