using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HalloXForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Klassische "MessageBox"
            // DisplayAlert("Meine erste Nachricht", "Hallo Welt", "OK");

            // "Ja/Nein - Messagebox"
            // DisplayAlert("Eine wichtige Frage", "Mittagspause ?", "Ja", "Verdammt nochmal, JA !");

            // Mehrere möglichkeiten als Dialog -  aka "Combobox-Dialog"
            // DisplayActionSheet("Pseudo-Combobox", "Ok", "Abbrechen", new string[] { "Apfel", "Birne", "Banane" });

            // async/await: UI-Thread kann weitermachen während gewartet
            string auswahl = await DisplayActionSheet("Pseudo-Combobox", "Ok", "Abbrechen", new string[] { "Apfel", "Birne", "Banane" });
            await DisplayAlert("Deine Auwahl war:", auswahl, "Yay !");

            // Synchron: -> Auf Task.Result warten (funktioniert wie Thread.Join(), blockiert das UI)
            // string auswahl2 =  DisplayActionSheet("Pseudo-Combobox", "Ok", "Abbrechen", new string[] { "Apfel", "Birne", "Banane" }).Result;

        }
    }
}
