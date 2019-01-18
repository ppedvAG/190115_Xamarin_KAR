using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sensoren
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatenSpeichernPage : ContentPage
	{
		public DatenSpeichernPage ()
		{
			InitializeComponent ();
		}

        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(FileSystem.AppDataDirectory, "demo.txt");
            File.WriteAllText(fullPath, entryDaten.Text);
            DisplayAlert("Speichern erfolgreich", $"Ihre Datei wurde unter '{fullPath}' abgespeichert", "Ok");

            //var service = DependencyService.Get<ISaveAndLoad>();
            //service.SaveText("demo.txt",entryDaten.Text);

            // Application-Properties: 
            // Werden immer erst dann gespeichert, wenn OnSleep() aufgerufen wird !!!
            Application.Current.Properties.Add("Notifications", true);

            // Speichern erzwingen
            // Application.Current.SavePropertiesAsync();
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(FileSystem.AppDataDirectory, "demo.txt");
            DisplayAlert("Laden", File.ReadAllText(fullPath), "Ok");
        }
    }
}