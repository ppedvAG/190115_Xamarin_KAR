using SQLite;
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
	public partial class SQLitePage : ContentPage
	{
		public SQLitePage ()
		{
			InitializeComponent ();
            string fullPath = Path.Combine(FileSystem.AppDataDirectory, "db.sqlite");

            con = new SQLiteConnection(fullPath); // Wenn die DB noch nicht existiert, wird sie erstellt. Wenn sie exisitert, wird sie geöffnet
            con.CreateTable<Person>(); // Wenn die Tabelle bereits da ist, passiert NICHTS
            con.s
        }

        private readonly SQLiteConnection con;


        private void ButtonEinfügen_Clicked(object sender, EventArgs e)
        {
            Person p = new Person
            {
                Vorname = entryName.Text,
                Nachname = "Mustermann",
                Alter = 10,
                Kontostand = 100
            };

            con.Insert(p);
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>().ToList();
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>().ToList();
            listViewPersonen.EndRefresh();
        }
    }
}