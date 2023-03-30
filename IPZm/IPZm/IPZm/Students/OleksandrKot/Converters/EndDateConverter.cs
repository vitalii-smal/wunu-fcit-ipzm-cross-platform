using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace IPZm.Students.OleksandrKot.Converters
{
    public class EndDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var endDate = value as DateTime?;
            if (endDate == null)
            {
                return null;
            }

            if (endDate.Value == DateTime.Today)
            {
                return "current";
            }

            return endDate.Value.ToString("MMM yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
