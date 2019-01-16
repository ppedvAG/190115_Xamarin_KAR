using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace BindingDemo
{
    class Farbconverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Color.FromHex()

            string farbe = (string)value;
            //if (farbe == "Rot")
            //    return Color.Red;
            //else if (farbe == "Grün")
            //    return Color.Green;
            //else
            //    return Color.Black;

            // Profi-Variante

            FieldInfo[] allfields = typeof(Color).GetFields();

            if (allfields.Any(x => x.Name.ToLower() == farbe.ToLower()))
            {
                return allfields.First(x => x.Name.ToLower() == farbe.ToLower())
                                .GetValue(typeof(Color));
            }
            else // Farbe nicht vorhanden
                return Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
