using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Sensoren
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DeviceDisplay.MainDisplayInfoChanged += (sender,e) => ChangeLayout(e.DisplayInfo);
            Appearing += (sender, e) => ChangeLayout(DeviceDisplay.MainDisplayInfo);

            //Button b = new Button();
            //b.Clicked += Demo123; // AddHandler
            //b.Clicked -= Demo123; // RemoveHandler
        }

        //private void Demo123(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void ChangeLayout(DisplayInfo d)
        {
            if (d.Orientation == DisplayOrientation.Landscape)
            {
                gridLandscape.IsVisible = true;
                gridPortrait.IsVisible = false;
            }
            else
            {
                gridLandscape.IsVisible = false;
                gridPortrait.IsVisible = true;
            }
        }
    }
}
