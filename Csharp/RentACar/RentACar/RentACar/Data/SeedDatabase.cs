using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Data
{
    public static class SeedDatabase
    {
        public static void SeedAdmin()
        {
            using var context = new DataContext();
            if (!context.Adminler.Any())
            {
                var admin = new Admin()
                {
                    KullaniciAdi="Admin",
                    Sifre="1453",
                    AdSoyad="Erkan Türk"
                }; 
                context.Adminler.Add(admin);
                context.SaveChanges();
                Console.WriteLine("Varsayılan Admin oluşturuldu /Admin / 1453");
            }
        }
    }
}
