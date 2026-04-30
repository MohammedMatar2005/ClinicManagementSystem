using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClinicManagementApplication.Views
{
    /// <summary>
    /// Interaction logic for SupportUC.xaml
    /// </summary>
    public partial class SupportUC : UserControl
    {
        public SupportUC()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("للتواصل معنا، يرجى إرسال بريد إلكتروني إلى");
        }
    }
}
