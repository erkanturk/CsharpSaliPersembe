using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction
{
    public class Ogrenci : Insan
    {
        public override long Tc { get; set; }
        public string DerslikSayisi { get; set; }
        public string Bolum { get; set; }


        public override void Create()
        {
            Console.WriteLine("Tc");
            Tc = Convert.ToInt64(Console.ReadLine());//Long değerler de ya long.Parse Yada Convert.ToInt64 kullanılır.
            Console.WriteLine("Bolum");
            Bolum = Console.ReadLine();
            Console.WriteLine("Derslik sayısı");
            DerslikSayisi = Console.ReadLine();
            Console.WriteLine("Ad");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            Soyad = Console.ReadLine();
            List();
        }

        public override void Delete()
        {
            Tc = 0;
            Bolum = "";
            DerslikSayisi = "";
            Ad = "";
            Soyad = "";
            List();

        }

        public override void List()
        {
            Console.WriteLine(Tc+" "+Ad+" "+Soyad+""+Bolum+" "+DerslikSayisi);
        }

        public override void Update()
        {
            Create();
        }
    }
}
