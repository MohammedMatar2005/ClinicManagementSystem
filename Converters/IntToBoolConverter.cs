using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ClinicManagemetApplication.Converters
{
    public class IntToBoolConverter : IValueConverter
    {
        // من ViewModel إلى View (لتحديد الزر المختار)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && value.Equals(int.Parse(parameter.ToString()));
        }

        // من View إلى ViewModel (عند الضغط على الزر)
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && value.Equals(true) ? int.Parse(parameter.ToString()) : Binding.DoNothing;
        }
    }
}
