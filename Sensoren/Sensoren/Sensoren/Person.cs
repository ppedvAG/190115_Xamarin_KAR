using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace Sensoren
{
    [Table("Personentabelle")]
    class Person
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [MaxLength(255)]
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        // [Ignore]
        public decimal Kontostand { get; set; }
    }

}
