using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmAdvancedSettings : Form
    {


        public frmAdvancedSettings()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connString = txtConnectionString.Text;

            bool isSuccess = false;

            isSuccess = CheckConnectionString(connString);

            if(isSuccess)
            {
                MessageBox.Show("الاتصال مع قاعدة البيانات خالي من المشاكل");
                return;
            }
            else
            {
                MessageBox.Show("سلسلة الاتصال غير صحيحة");
                return;
            }
      
    
        }
        
          


        private bool CheckConnectionString(string connString)
        {
            using (var connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
