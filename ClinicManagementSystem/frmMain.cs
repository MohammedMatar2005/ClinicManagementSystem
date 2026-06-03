using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness;
using ClinicBusiness.Services;
using ClinicDataAccess.Interfaces;


namespace ClinicManagementSystem
{

    

    public partial class frmMain : Form
    {
       // IPaymentRepository _paymentRepository;

        public frmMain()
        {
            InitializeComponent();
           // _paymentRepository = paymentRepository;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Form frm = new frmPatients();
            frm.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Form frm = new frmAppointments();
            frm.ShowDialog();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Form frm = new frmDoctor();
            frm.ShowDialog();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Later...");
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Form frm = new frmInvoices();
            frm.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            Form frm = new frmSupport();
            frm.ShowDialog();
        }

        private void pagesContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //clsPayment payments = new clsPayment(_paymentRepository);

            //var todayPayments = payments.GetPaymentAmountsToday();
            //lblValueRevenue.Text = todayPayments.ToString();

        }
    }
}
