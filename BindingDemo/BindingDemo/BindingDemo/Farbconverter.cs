using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BindingDemo
{
    class Farbconverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string farbe = (string)value;
            if (farbe == "Rot")
                return Color.Red;
            else if (farbe == "Grün")
                return Color.Green;
            else
                return Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
