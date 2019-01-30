using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt.Models
{
    public class Polmaraton2015
    {
        public int ID { get; set; }
        public int ID_zaw { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Klub { get; set; }
        public string Kraj { get; set; }
        public DateTime Data_urodzenia { get; set; }
        public string Kat_wiek { get; set; }
        public string Plec { get; set; }
        public double Tempo { get; set; }
        public double Ptk_1 { get; set; }
        public double Ptk_2 { get; set; }
        public double Wynik { get; set; }
        public int M { get; set; }
        public int K { get; set; }
        public virtual ICollection<Uczestnicy> Uczestnicies
        { get; set; }
    }
}