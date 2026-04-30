using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RentACar.Models;

namespace RentACar.Data
{
    public class DataContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=204-HOCAPC1;Database=RentACar;uid=sa;pwd=1;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Araba>()
                .HasOne(a => a.Marka)//Arabanın markası var
                .WithMany(m => m.Arabalar)//Markanın arabaları var
                .HasForeignKey(x => x.MarkaId);//İlişkisel yapısı MarkaId

            modelBuilder.Entity<Kiralama>()
                .HasOne(k => k.Musteri)
                .WithMany(m => m.Kiralamas)
                .HasForeignKey(k => k.MusteriId);

            modelBuilder.Entity<Kiralama>()
                .HasOne(m => m.Araba)
                .WithMany(x => x.Kiralamalar)
                .HasForeignKey(a => a.ArabaId);

            modelBuilder.Entity<Bildirim>()
                .HasOne(b => b.Kiralama)
                .WithMany()
                .HasForeignKey(b => b.KiralamaId);
            
        }

        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
        public DbSet<Musteri> Musteriler {  get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Bildirim> Bildirimler {  get; set; }
    }
}
