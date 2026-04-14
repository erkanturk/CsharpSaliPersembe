using _44_Ado.Net.Data;
using _44_Ado.Net.Models;
using Microsoft.Data.SqlClient;

namespace _44_Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ado.Net bir sql injection yapısıdır.
             * Sql bağlantısı için kullanılır ve bu alanda yaptığımız işler veri tabanına aktarım sağlanması için 
             * gerekli yapılar kullanılır
             * Veri tabanında DML olan işlemleri Crud olarak backend yapısında yazarız.
             * Ado.Net yapısı code first çalışmaz doğrudan DbFirst yapısı ile şekillenir.
             */
            DataContext context = new DataContext();

           Ogretmen ogretmen = new Ogretmen();
            //Console.WriteLine("Ad");
            //ogretmen.Ad = Console.ReadLine();
            //Console.WriteLine("Soyad");
            //ogretmen.Soyad = Console.ReadLine();
            //Console.WriteLine("Yaş");
            //ogretmen.Yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Branş");
            //ogretmen.Brans = Console.ReadLine();

            ////Console.WriteLine(context.OgretmenEkle());//parametresiz içerisindeki değeri alır
            //context.OgretmenEkle(ogretmen);//Kullanıcıdan gelen değerleri alacak 

            //Console.WriteLine("Aranacak Öğretmen");
            //string ad = Console.ReadLine();
            SqlDataReader reader = context.Listele();//Sql tarafında Ogretmen tablosundaki tüm kayıtları oku
            while (reader.Read())
            {
                Console.WriteLine($"ID:{reader[0].ToString()} AD: {reader[1].ToString()} " +
                    $"SOYAD:{reader[2].ToString()} YAŞ:{reader[3].ToString()} BRANŞ:{reader[4].ToString()}");
            }

            Console.WriteLine("Silinmesi gereken öğretmen Id si");
            int id = Convert.ToInt32(Console.ReadLine());
            context.Delete(id);
            SqlDataReader reader2 = context.Listele();//Sql tarafında Ogretmen tablosundaki tüm kayıtları oku
            while (reader2.Read())
            {
                Console.WriteLine($"ID:{reader2[0].ToString()} AD: {reader2[1].ToString()} " +
                    $"SOYAD:{reader2[2].ToString()} YAŞ:{reader2[3].ToString()} BRANŞ:{reader2[4].ToString()}");
            }
        }
    }
}
