using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Class_Object_2
{
    internal class Buzdolabi//non static
    {
        public int Id;
        public string Marka;
        public string Model;
        public double Fiyat;

        public static void Ekle(List<Buzdolabi> lists)//static
        {
            Buzdolabi buzdolabi = new Buzdolabi();
            Console.WriteLine("Marka");
            buzdolabi.Marka = Console.ReadLine();
            Console.WriteLine("Model");
            buzdolabi.Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            buzdolabi.Fiyat = Convert.ToDouble(Console.ReadLine());

            lists.Add(buzdolabi);
            Console.WriteLine($"Marka: {buzdolabi.Marka} Model: {buzdolabi.Model} Fiyat: {buzdolabi.Fiyat}");
        }
        public static void OzellikYaz()//static
        {
            Buzdolabi buzdolabi = new Buzdolabi();
            Console.WriteLine($"Marka: {buzdolabi.Marka} Model: {buzdolabi.Model} Fiyat: {buzdolabi.Fiyat}");
        }

        public void Kaydet()//nonstatic
        {
            Console.WriteLine("Marka");
            Marka = Console.ReadLine();
            Console.WriteLine("Model");
            Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat = Convert.ToDouble(Console.ReadLine());
        }
        public void Yazdir()//nonstatic
        {
            Console.WriteLine($"Marka: {Marka} Model: {Model} Fiyat: {Fiyat}");
        }
        public  void Insert(List<Buzdolabi> lists)//nonsatic
        {
           
            Console.WriteLine("Marka");
            Marka = Console.ReadLine();
            Console.WriteLine("Model");
            Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat = Convert.ToDouble(Console.ReadLine());

            lists.Add(this);//buradaki yapıyı ekle

        }

    }
}
