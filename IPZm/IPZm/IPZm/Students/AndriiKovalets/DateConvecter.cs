using System;
using System.Globalization;
using Xamarin.Forms;

namespace IPZm.Students.AndriiKovalets
{
    public class DateConvecter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var date = value as DateTime?;

            if(date == DateTime.Today)
            {
                return "current";
            }

            return date?.ToString("MMM yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
