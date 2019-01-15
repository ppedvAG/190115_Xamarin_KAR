using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Layoutcontainer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Style = (Style)this.Resources["blueButtonStyle"];

            // Unterschied zwischen StaticResource und DynamicResource:
            // Static:  Wertänderungen werden erkannt, XAML-Parser nimmt die Ressource sofort
            // Dynamic: Referenzänderungen werden erkannt (zb neues Objekt), XAML-Parser löst es nach beenden des Parsens auf
        }
    }
}
