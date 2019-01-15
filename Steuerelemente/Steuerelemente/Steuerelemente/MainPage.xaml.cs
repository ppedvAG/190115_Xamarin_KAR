using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Steuerelemente
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (entryUsername.Text == "Max Mustermann" && entryPasswort.Text == "geheim")
                DisplayAlert("Login", "Login erfolgreich !!!", "Ok");
        }
    }
}
