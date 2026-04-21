using _47_ManavOtomasyon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _47_ManavOtomasyon.Data
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=204-HOCAPC1;Database=ManavDb;uid=sa;pwd=1;TrustServerCertificate=true");
        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Manav> Manavlar { get; set; }
    }
}
