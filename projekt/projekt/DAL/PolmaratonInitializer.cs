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
           /* var uczestnicies = new List<Uczestnicy>
            {
                new Uczestnicy{ID=1, Imie="Olena", Nazwisko="Burkovska", Miasto="Kijów", Klub="", Kraj="Ukraina", Data_urodzenia=DateTime.Parse("1981-05-22"), Plec="K", Wynik_2014=0, Wynik_2015=0, Wynik_2016=2, Wynik_2017=2, Wynik_2018=3 },
                new Uczestnicy{ID=2, Imie="Andrzej", Nazwisko="Rogiewicz", Miasto="Grudziądz", Klub="Pac Man Team", Kraj="Polska", Data_urodzenia=DateTime.Parse("1993-11-13"), Plec="M", Wynik_2014=1, Wynik_2015=0, Wynik_2016=3, Wynik_2017=3, Wynik_2018=0 },
                new Uczestnicy{ID=3, Imie="Betty", Nazwisko="Chepleting", Miasto="Nairobi", Klub="Benedek Team", Kraj="Kenia", Data_urodzenia=DateTime.Parse("1988-07-03"), Plec="K", Wynik_2014=2, Wynik_2015=1, Wynik_2016=1, Wynik_2017=1, Wynik_2018=2 }

            };

            uczestnicies.ForEach(s => context.Uczestnicies.Add(s));
            context.SaveChanges();

            var polmaraton2018s = new List<Polmaraton2018>
            {
                new Polmaraton2018{ID=1,ID_zaw=3, Imie="Betty", Nazwisko="Chepleting", Miasto="Nairobi", Klub="Benedek Team", Kraj="Kenia", Data_urodzenia=DateTime.Parse("1988-07-03"), Kat_wiek="K20", Plec="K", Tempo=3.56, Ptk_1=17.23, Ptk_2=25.16, Wynik=42.39, M=0, K=1  },
                new Polmaraton2018{ID=2, ID_zaw=1, Imie="Olena", Nazwisko="Burkovska", Miasto="Kijów", Klub="", Kraj="Ukraina", Data_urodzenia=DateTime.Parse("1981-05-22"), Kat_wiek="K30", Plec="K", Tempo=4.23, Ptk_1=18.53, Ptk_2=26.02, Wynik=44.55, M=0, K=2  },

            };

            polmaraton2018s.ForEach(s => context.Polmaraton2018s.Add(s));
            context.SaveChanges();

            var polmaraton2017s = new List<Polmaraton2017>
            {
                new Polmaraton2017{ID=1, ID_zaw=3, Imie="Betty", Nazwisko="Chepleting", Miasto="Nairobi", Klub="Benedek Team", Kraj="Kenia", Data_urodzenia=DateTime.Parse("1988-07-03"), Kat_wiek="K20", Plec="K", Tempo=3.21, Ptk_1=15.42, Ptk_2=20.12, Wynik=35.54, M=0, K=1  },
                new Polmaraton2017{ID=2, ID_zaw=1, Imie="Olena", Nazwisko="Burkovska", Miasto="Kijów", Klub="", Kraj="Ukraina", Data_urodzenia=DateTime.Parse("1981-05-22"), Kat_wiek="K30", Plec="K", Tempo=3.43, Ptk_1=16.22, Ptk_2=21.30, Wynik=37.52, M=0, K=2  },
                new Polmaraton2017{ID=3, ID_zaw=2, Imie="Andrzej", Nazwisko="Rogiewicz", Miasto="Grudziądz", Klub="Pac Man Team", Kraj="Polska", Data_urodzenia=DateTime.Parse("1993-11-13"), Kat_wiek="M20", Plec="M", Tempo=4.27, Ptk_1=17.21, Ptk_2=24.18, Wynik=41.39, M=1, K=0  },

            };

            polmaraton2017s.ForEach(s => context.Polmaraton2017s.Add(s));
            context.SaveChanges();

            var polmaraton2016s = new List<Polmaraton2016>
            {
                new Polmaraton2016{ID=1, ID_zaw=3, Imie="Betty", Nazwisko="Chepleting", Miasto="Nairobi", Klub="Benedek Team", Kraj="Kenia", Data_urodzenia=DateTime.Parse("1988-07-03"), Kat_wiek="K20", Plec="K", Tempo=4.15, Ptk_1=19.15, Ptk_2=17.38, Wynik=36.53, M=0, K=1  },
                new Polmaraton2016{ID=2, ID_zaw=1, Imie="Olena", Nazwisko="Burkovska", Miasto="Kijów", Klub="Ukraina", Kraj="Polska", Data_urodzenia=DateTime.Parse("1981-05-22"), Kat_wiek="K30", Plec="K", Tempo=4.32, Ptk_1=20.36, Ptk_2=18.05, Wynik=38.41, M=0, K=2  },
                new Polmaraton2016{ID=3, ID_zaw=2, Imie="Andrzej", Nazwisko="Rogiewicz", Miasto="Grudziądz", Klub="Pac Man Team", Kraj="Polska", Data_urodzenia=DateTime.Parse("1993-11-13"), Kat_wiek="M20", Plec="M", Tempo=5.01, Ptk_1=22.14, Ptk_2=20.41, Wynik=42.55, M=1, K=0  },

            };

            polmaraton2016s.ForEach(s => context.Polmaraton2016s.Add(s));
            context.SaveChanges();

            var polmaraton2015s = new List<Polmaraton2015>
            {
                new Polmaraton2015{ID=1, ID_zaw=3, Imie="Betty", Nazwisko="Chepleting", Miasto="Nairobi", Klub="Benedek Team", Kraj="Kenia", Data_urodzenia=DateTime.Parse("1988-07-03"), Kat_wiek="K20", Plec="K", Tempo=5.32, Ptk_1=25.16, Ptk_2=27.32, Wynik=52.48, M=0, K=1  },

            };

            polmaraton2015s.ForEach(s => context.Polmaraton2015s.Add(s));
            context.SaveChanges();

            var polmaraton2014s = new List<Polmaraton2014>
            {
                new Polmaraton2014{ID=1, ID_zaw=2, Imie="Andrzej", Nazwisko="Rogiewicz", Miasto="Grudziądz", Klub="Pac Man Team", Kraj="Polska", Data_urodzenia=DateTime.Parse("1993-11-13"), Kat_wiek="M20", Plec="M", Tempo=3.21, Ptk_1=18.14, Ptk_2=19.29, Wynik=37.43, M=1, K=0  },
                new Polmaraton2014{ID=2, ID_zaw=3, Imie="Betty", Nazwisko="Chepleting", Miasto="Nairobi", Klub="Benedek Team", Kraj="Kenia", Data_urodzenia=DateTime.Parse("1988-07-03"), Kat_wiek="K20", Plec="K", Tempo=3.36, Ptk_1=18.35, Ptk_2=20.05, Wynik=38.4, M=0, K=1  },

            };

            polmaraton2014s.ForEach(s => context.Polmaraton2014s.Add(s));
            context.SaveChanges();*/
        }
    }
}