using System;
using System.Globalization;
using System.Windows.Data;

namespace tweetz.core.Converters
{
    public class DoubleFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var format = parameter as string ?? "N";
            return ((double)value).ToString(format, CultureInfo.CurrentUICulture);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("General", "RCS1079:Throwing of new NotImplementedException.")]
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}