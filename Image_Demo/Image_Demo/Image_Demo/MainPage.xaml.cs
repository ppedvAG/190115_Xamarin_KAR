using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Image_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //UriImageSource source = (UriImageSource)ImageSource.FromUri(new Uri("http://placekitten.com/g/500/500"));
            //// source.CachingEnabled // Standard: Ja
            //// source.CacheValidity // Standard: 24h

            //source.CacheValidity = TimeSpan.FromMinutes(10);
            //imageTier.Source = source;

            // Aus einem nativen Projekt:
            // ImageSource.FromFile("katze.jpg")

            // Aus der .NET Standard-Lib:
            // Resouce-ID: Projektname.Ordnername.Dateiname.Extension
            // katze.jpg: Properties -> BuildAction -> EmbeddedResource
            // imageTier.Source =  ImageSource.FromResource("Image_Demo.Icons.katze.jpg");
        }
    }
}
