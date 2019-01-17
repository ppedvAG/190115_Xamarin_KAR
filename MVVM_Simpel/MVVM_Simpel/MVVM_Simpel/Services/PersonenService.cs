using MVVM_Simpel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Simpel.Services
{
    public class PersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
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
    }
}
