using Adigabze.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.Data.Concrete.EFCore
{
    public class AdigabzeContext : DbContext
    {
        public AdigabzeContext(DbContextOptions<AdigabzeContext> options) : base(options)
        {

        }

        public DbSet<Yetkinlik> Yetkinlikler { get; set; }
        public DbSet<Unite> Uniteler { get; set; }
        public DbSet<Konu> Konular { get; set; }
        public DbSet<Kazanim> Kazanimlar { get; set; }

        public DbSet<Dil> Diller { get; set; }
        public DbSet<Harf> Alfabe { get; set; }
        public DbSet<Anahtar> Dizin { get; set; }
        //public DbSet<EsAnlamTR> EsAnlamlarTR { get; set; }
        //public DbSet<ZitAnlamTR> ZitAnlamlarTR { get; set; }
        //public DbSet<EsAnlamAD> EsAnlamlarAD { get; set; }
        //public DbSet<ZitAnlamAD> ZitAnlamlarAD { get; set; }
        public DbSet<Sozcuk> Sozluk { get; set; }
        //public DbSet<AnahtarHaritasi> AnahtarHaritasi { get; set; }
        //public DbSet<FiilCati> FiilCatisi { get; set; }
        public DbSet<SozcukEk> Ekler { get; set; }

        public DbSet<Sulale> Sulaleler { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<AnahtarHaritasi>()
        //        .HasKey(pk => new { pk.AnahtarTRId, pk.AnahtarADId });

        //    builder.Entity<SozcukHaritasi>()
        //        .HasKey(pk => new { pk.SozcukTRId, pk.SozcukADId });
        //}
    }
}
