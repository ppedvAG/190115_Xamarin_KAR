using MVVM_Simpel.Models;
using MVVM_Simpel.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Simpel.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            // Kontrollfreak-Antipattern
            service = new PersonenService();
            GetPersonenCommand = new Command(GetPersonen);
        }

        private readonly PersonenService service;

        private List<Person> personenliste;
        public List<Person> Personenliste
        {
            // Seit C# 7.0
            get => personenliste;
            set => SetProperty(ref personenliste, value);
        }
        public Command GetPersonenCommand { get; set; }
        private void GetPersonen(object obj)
        {
            Personenliste = service.GetPersonen();
            // ObservableCollection<T> -> Add(), Remove(), Clear()
            // BindingList<T> -> Schaut auch auf die Properties der Elemente IN der Liste (z.B. Vorname ändern = Aktualisierung)
        }
    }
}
