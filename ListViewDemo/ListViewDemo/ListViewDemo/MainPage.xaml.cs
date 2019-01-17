using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private List<Person> data;
        private void PersonenLaden()
        {
            data = new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100m,Telefonnummer="12345"},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200m,Telefonnummer="12345"},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=3000m,Telefonnummer="12345"},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-4000m,Telefonnummer="12345"},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=500000m,Telefonnummer="12345"},
                new Person{Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=66666m,Telefonnummer="12345"},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=-10000m,Telefonnummer="12345"},
                new Person{Vorname="Frank N",Nachname="Stein",Alter=80,Kontostand=88888m,Telefonnummer="12345"},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=90,Kontostand=-12345m,Telefonnummer="12345"},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=100,Kontostand=100000000m,Telefonnummer="12345"}
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PersonenLaden();
            listViewPersonen.ItemsSource = data;
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            PersonenLaden();
            listViewPersonen.ItemsSource = data;

            // 2 Varianten
            // listViewPersonen.IsRefreshing = false;

            listViewPersonen.EndRefresh();
        }

        private void SearchBarVorname_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Anforderung:
            // Searchbar.Text = "An" ... alle personen, deren Vorname mit "An" anfängt
            // string demotext = "abc":
            // if demotext.StartsWith("a") // ....

            if (data.Count == 0)
                return;

            // LINQ - WHERE
            listViewPersonen.ItemsSource = data.Where(x => x.Vorname.ToLower().StartsWith(searchBarVorname.Text.ToLower())).ToArray(); // meine gefilterte liste
        }

        private void MenuItemInfo_Clicked(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            var person = item.CommandParameter as Person;

            DisplayAlert("Infos:", $"{person.Vorname} {person.Nachname} | Alter: {person.Alter}", "Ok");
        }

        private void MenuItemLöschen_Clicked(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            var person = item.CommandParameter as Person;

            data.Remove(person);

            // Hack, schöner wäre eine ObservableCollection<T> ;) (Siehe MVVM - Kapitel)
            listViewPersonen.ItemsSource = null;
            listViewPersonen.ItemsSource = data;
        }
    }
}
