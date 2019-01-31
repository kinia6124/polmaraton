using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt.Models
{
    public class Uczestnicy
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Klub { get; set; }
        public string Kraj { get; set; }
        public DateTime Data_urodzenia { get; set; }
        public string Plec { get; set; }
        public int Wynik_2018 { get; set; }
        public int Wynik_2017 { get; set; }
        public int Wynik_2016 { get; set; }
        public int Wynik_2015 { get; set; }
        public int Wynik_2014 { get; set; }
        public virtual Polmaraton2014 Polmaraton2014 { get; set; }
        public virtual Polmaraton2015 Polmaraton2015 { get; set; }
        public virtual Polmaraton2016 Polmaraton2016 { get; set; }
        public virtual Polmaraton2017 Polmaraton2017 { get; set; }
        public virtual Polmaraton2018 Polmaraton2018 { get; set; }


    }
}