using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt.Models
{
    public class Polmaraton2018
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Klub { get; set; }
        public string Kraj { get; set; }
        public DateTime Data_urodzenia { get; set; }
    }
}