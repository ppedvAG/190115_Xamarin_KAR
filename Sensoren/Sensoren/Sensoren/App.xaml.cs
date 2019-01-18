using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Sensoren
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPageRoot();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            if (Properties.ContainsKey("Notifications"))
            {
                MainPage.DisplayAlert("Notifications", Properties["Notifications"].ToString(), "Ok");
            }
            else
            {
                MainPage.DisplayAlert("Notifications", "Nicht vorhanden !", "Ok");
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            // var locationPage = (MainPage as TabbedPageRoot).Children.First(x => x.GetType() == typeof(GeolocationPage));
        }
    }
}
