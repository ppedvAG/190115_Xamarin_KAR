using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace Sensoren
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GeolocationPage : ContentPage
	{
		public GeolocationPage ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromSeconds(10), CheckLocation);
		}

        private bool CheckLocation()
        {
            ContentPage_Appearing(null, null);
            return false;
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                labelLatitude.Text = location.Latitude.ToString();
                labelLongitute.Text = location.Longitude.ToString();
            }
            catch (FeatureNotSupportedException ex)
            {
                await DisplayAlert("Feature not supported", ex.Message, "Ok");
            }
            catch (PermissionException ex)
            {
                await DisplayAlert("Permission", ex.Message, "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Unbekannter Fehler", ex.Message, "Ok");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Map.OpenAsync(new Location(48.220684, 16.3800599));
        }
    }
}