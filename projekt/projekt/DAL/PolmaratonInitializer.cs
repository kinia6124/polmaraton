using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using projekt.Models;

namespace projekt.DAL
{
    public class PolmaratonInitializer:
        System.Data.Entity.DropCreateDatabaseIfModelChanges<PolmaratonContext>
    {
        protected override void Seed(PolmaratonContext context)
        {
            var uczestnicies = new List<Uczestnicy>
            {
                new Uczestnicy{Imie="", Nazwisko="", Miasto="", Klub="", Kraj="", Data_urodzenia=DateTime.Parse("rrrr-mm-dd"), Plec="", Wynik_2014= , Wynik_2015= ,Wynik_2016= ,Wynik_2017= ,Wynik_2018= },
                new Uczestnicy{Imie="", Nazwisko="", Miasto="", Klub="", Kraj="", Data_urodzenia=DateTime.Parse("rrrr-mm-dd"), Plec="", Wynik_2014= , Wynik_2015= ,Wynik_2016= ,Wynik_2017= ,Wynik_2018= },
                new Uczestnicy{Imie="", Nazwisko="", Miasto="", Klub="", Kraj="", Data_urodzenia=DateTime.Parse("rrrr-mm-dd"), Plec="", Wynik_2014= , Wynik_2015= ,Wynik_2016= ,Wynik_2017= ,Wynik_2018= }

            };

            uczestnicies.ForEach(s => context.Uczestnicies.Add(s));
            context.SaveChanges();
        }
    }
}