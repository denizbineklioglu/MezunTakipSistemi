using MezunTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MezunTakipSistemi.DAL
{
    public class Context :DbContext
    {
        public Context() : base("MezunVT") { }

        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}