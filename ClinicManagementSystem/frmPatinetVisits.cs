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
    public partial class frmPatinetVisits : Form
    {
        public frmPatinetVisits()
        {
            InitializeComponent();

            // إجبار الحاوية الرئيسية على الملء وإعادة الترتيب تلقائياً عند التشغيل
            pnlMainBackground.Dock = DockStyle.Fill;
            tabControlVisits.Dock = DockStyle.Fill;

            // إجبار الـ TableLayout الكبيرة على التمدد الكامل داخل التبويب
            tlpNewVisitMain.Dock = DockStyle.Fill;
            tlpHistoryMain.Dock = DockStyle.Fill;

            lblPatient.BringToFront();
            lblDoctor.BringToFront();
            lblBloodPressure.BringToFront();
            lblTemperature.BringToFront();
            lblHeartRate.BringToFront();
            lblWeight.BringToFront();
            lblHeight.BringToFront();

            // تنشيط التحديث البصري
            this.Refresh();
        }
    }
}
