using Adigabze.DAL.Entities;
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

        public DbSet<Parent> Parents {  get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageEvaluation> ImageEvaluations { get; set; }
        public DbSet<User> Users { get; set; }


        public DbSet<Yetkinlik> Yetkinlikler { get; set; }
        public DbSet<Unite> Uniteler { get; set; }
        public DbSet<Konu> Konular { get; set; }
        public DbSet<Kazanim> Kazanimlar { get; set; }
        public DbSet<Dil> Diller { get; set; }
        public DbSet<Harf> Alfabe { get; set; }
        public DbSet<Anahtar> Dizin { get; set; }
        public DbSet<Sozcuk> Sozluk { get; set; }
        public DbSet<SozcukEk> Ekler { get; set; }
        public DbSet<Sulale> Sulaleler { get; set; }

    }
}
