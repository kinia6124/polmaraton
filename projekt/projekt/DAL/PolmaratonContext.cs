using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using projekt.Models;

namespace projekt.DAL
{
    public class PolmaratonContext :DbContext
    { 
        public PolmaratonContext():base("PolmaratonContext")
        {

        }

        public DbSet<Polmaraton2014> Polmaraton2014s { get; set; }
        public DbSet<Polmaraton2015> Polmaraton2015s { get; set; }
        public DbSet<Polmaraton2016> Polmaraton2016s { get; set; }
        public DbSet<Polmaraton2017> Polmaraton2017s { get; set; }
        public DbSet<Polmaraton2018> Polmaraton2018s { get; set; }
        public DbSet<Uczestnicy> Uczestnicies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}