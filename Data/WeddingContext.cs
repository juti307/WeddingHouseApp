using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WeddingHouseApp.Data
{
    public class WeddingContext : DbContext
    {
        public WeddingContext(DbContextOptions options) : base(options) { }
        public DbSet<Adres_korespondencyjny> Adres_korespondencyjny { get; set; }
        public DbSet<Dokument> Dokument { get; set; }
        public DbSet<Klient> Klient { get; set; }
        public DbSet<Kontakt> Kontakt { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Osoba_personalia> Osoba_personalia { get; set; }
        public DbSet<Para_mloda> Para_mloda { get; set; }
        public DbSet<Pracownik> Pracownik { get; set; }
        public DbSet<Rozliczenia_szczegoly> Rozliczenia_szczegoly { get; set; }
        public DbSet<Umowa> Umowa { get; set; }
        public DbSet<Wesele_szczegoly> Wesele_szczegoly { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba_personalia>()
                .HasOne(b => b.Dokument)
                .WithOne(i => i.Osoba_personalia)
                .HasForeignKey<Dokument>(b => b.Osoba_personaliaID);
       
            modelBuilder.Entity<Osoba_personalia>()
                .HasOne(b => b.Klient)
                .WithOne(i => i.Osoba_personalia)
                .HasForeignKey<Klient>(b => b.Osoba_personaliaID);
 
            modelBuilder.Entity<Osoba_personalia>()
                .HasOne(b => b.Pracownik)
                .WithOne(i => i.Osoba_personalia)
                .HasForeignKey<Pracownik>(b => b.Osoba_personaliaID);

            modelBuilder.Entity<Wesele_szczegoly>()
              .HasOne(b => b.Rozliczenia_szczegoly)
              .WithOne(i => i.Wesele_szczegoly)
              .HasForeignKey<Rozliczenia_szczegoly>(b => b.Wesele_szczegolyID);
        }
    }
}
