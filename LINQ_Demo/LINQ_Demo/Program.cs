using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Personenliste = new List<Person>
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


            //// Aufgabe: Gib mir den Vornamen von jeder Person in einer neuen Liste aus
            //List<string> alleVornamen = new List<string>();
            //foreach (var item in Personenliste)
            //{
            //    alleVornamen.Add(item.Vorname);
            //}

            //// Aufgabe: alle Vornamen + Nachnamen von Personen mit negativem Kontostand
            //List<string> alleMitSchulden = new List<string>();
            //foreach (var item in Personenliste)
            //{
            //    if(item.Kontostand < 0)
            //        alleVornamen.Add($"{item.Vorname} {item.Nachname}");
            //}

            // SELECT -> Elemente aus einer Auflistung herausnehmen (Nimmt ein Element, Verarbeitet es, gibt etwas zurück)
            var alleVornamen = Personenliste.Select(person => person.Vorname)
                                            .ToArray();

            var alleKontostände = Personenliste.Select(x => x.Kontostand).ToArray();

            // WHERE -> Gibt nur die elemente zurück, bei denen die Bedingung zutrifft
            var alleMitNegativemKontostand = Personenliste.Where(x => x.Kontostand < 0)
                                                          .Select(x => $"{x.Vorname} {x.Nachname}")
                                                          .ToArray();

            var personenÜber50 = Personenliste.Where(x => x.Alter >= 50).ToArray();

            // Alle Personen über 50 sortiert nach Kontostand ->
            // ORDERBY

            var über50Sortiert = Personenliste.Where(x => x.Alter >= 50)
                                              .OrderByDescending(x => x.Kontostand)
                                              .Select(x => x.Telefonnummer)
                                              .ToArray();

            // Durschnittskontostand
            //var kontostandDurchschnitt = Personenliste.Where(x => x.Alter < 30)
            //                                          .Select(x=> x.Kontostand)                                      
            //                                          .Average();
            var kontostandDurchschnitt = Personenliste.Where(x => x.Alter < 30)
                                                      .Average(x => x.Kontostand);

            // Min(), Max(), Sum()

            // First(), Last()
            // FirstOrDefault
            // Finde die reichste Person über 50 und gib mir die Tel.

            var reichstePerson = Personenliste.Where(x => x.Alter > 50)
                                              .OrderByDescending(x => x.Kontostand)
                                              .First().Telefonnummer;

            // Hat irgendeine Person exakt 55€ ?
            var hatEiner55 = Personenliste.Any(x => x.Kontostand == 55);

            #region Strings
            //string t1 = "Hallo";
            //string t2 = "Welt";
            //string t3 = "!";

            //string ganzSchlecht = t1 + " " + t2 + " " + t3;
            //string bisschenBesser = String.Format("{0} und {1} und {2}", t1, t2, t3);

            //// C# 6.0
            //// String-Interpolation
            //string gut = $"{t1} {t2} {t3}";
            //int z1 = 5, z2 = 10;
            //Console.WriteLine($"Die Summe von {z1} und {z2} ist {z1 + z2}"); 
            #endregion
            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static string GibVornameZurück (Person arg) => arg.Vorname;
        //{
        //    return arg.Vorname;
        //}

        public static int Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        public static int Addieren2(int zahl1, int zahl2) => zahl1 + zahl2;
    }


    //static class Erweiterungsmethoden
    //{
    //    public static string Umdrehen(this string input)
    //    {
    //        return null;
    //    }
    //}

}
