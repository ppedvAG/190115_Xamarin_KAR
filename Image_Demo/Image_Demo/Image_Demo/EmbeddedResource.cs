using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Image_Demo
{
    [ContentProperty(nameof(ID))] // Standard-Property für die Kurzform (wie {Binding Value})
    class EmbeddedResource : IMarkupExtension
    {
        public string ID { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(ID))
                return null;
            else
                return ImageSource.FromResource(ID);
        }
    }
}
