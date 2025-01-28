using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IzlucnoNatjecanje.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<Kategorija> Kategorije { get; set; }
        public virtual DbSet<KreditnaKartica> KreditneKartice { get; set; }
        public virtual DbSet<Kupac> Kupci { get; set; }
        public virtual DbSet<MetodaDostave> MetodeDostave { get; set; }
        public virtual DbSet<Potkategorija> Potkategorije { get; set; }
        public virtual DbSet<Proizvod> Proizvodi { get; set; }
        public virtual DbSet<Racun> Racuni { get; set; }
        public virtual DbSet<StavkaRacuna> StavkeRacuna { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategorija>()
                .HasMany(e => e.Potkategorija)
                .WithRequired(e => e.Kategorija)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MetodaDostave>()
                .Property(e => e.Cijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MetodaDostave>()
                .HasMany(e => e.Racun)
                .WithRequired(e => e.MetodaDostave)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proizvod>()
                .HasMany(e => e.StavkaRacuna)
                .WithRequired(e => e.Proizvod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Racun>()
                .HasMany(e => e.StavkaRacuna)
                .WithRequired(e => e.Racun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StavkaRacuna>()
                .Property(e => e.JedinicnaCijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StavkaRacuna>()
                .Property(e => e.JedinicnaCijenaUmanjenje)
                .HasPrecision(19, 4);
        }
    }
}
