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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (wizardTabs.SelectedIndex < wizardTabs.TabCount - 1)
            {
                wizardTabs.SelectedIndex++;
                UpdateWizardHeader();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wizardTabs.SelectedIndex > 0)
            {
                wizardTabs.SelectedIndex--;
                UpdateWizardHeader();
            }
        }


        private void UpdateWizardHeader()
        {
            int currentStep = wizardTabs.SelectedIndex + 1;
            int totalSteps = wizardTabs.TabCount;

            // 1. تحديث عداد المراحل (المرحلة X من Y)
            lblStepCount.Text = $"المرحلة {currentStep} من {totalSteps}";

            // 2. تحديث عنوان المرحلة بناءً على التبويب الحالي
            switch (wizardTabs.SelectedIndex)
            {
                case 0:
                    lblStepTitle.Text = "البيانات الشخصية للطبيب";
                    btnBack.Enabled = false; // تعطيل زر السابق في أول مرحلة
                    btnNext.Enabled = true;
                    break;
                case 1:
                    lblStepTitle.Text = "إعدادات حساب المستخدم";
                    btnBack.Enabled = true;
                    btnNext.Enabled = true;
                    break;
                case 2:
                    lblStepTitle.Text = "البيانات المهنية والمالية";
                    btnBack.Enabled = true;
                    btnNext.Enabled = false; // تعطيل زر التالي في آخر مرحلة (لأن هناك زر حفظ كامل)
                    break;
            }
        }
    }
}
