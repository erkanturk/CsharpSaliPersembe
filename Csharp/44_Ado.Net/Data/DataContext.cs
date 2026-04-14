using _44_Ado.Net.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Ado.Net.Data
{
    internal class DataContext
    {
        private readonly SqlConnection _con;
        //SqlConnection Veri tabanı bağlantısı
        public DataContext()
        {
            _con = new SqlConnection(@"Server=204-HOCAPC1;Database=OkulDb;uid=sa;pwd=1;TrustServerCertificate=true");

        }

        public int OgretmenEkle()
        {
            var eks = 0;
            try
            {
                //Sql sorguları için Create Read Update Delete 
                SqlCommand cmd = new SqlCommand($"Insert into Ogretmen (Ad,Soyad,Yas,Brans) Values ('Erkan','Türk','32','Yazılım')", _con);
                _con.Open();
                eks = cmd.ExecuteNonQuery();//Create Update Delete (ekleme,güncelleme,silme)
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:", ex.Message);
            }
            finally
            {
                _con.Close();
            }
            return eks;
        }
        public void OgretmenEkle(Ogretmen ogretmen)
        {

            SqlCommand cmd = new SqlCommand($"Insert into Ogretmen (Ad,Soyad,Yas,Brans)" +
                $"values('{ogretmen.Ad}','{ogretmen.Soyad}','{ogretmen.Yas}','{ogretmen.Brans}')", _con);
            _con.Open();
            cmd.ExecuteNonQuery();
            _con.Close();

        }
        public SqlDataReader Listele()
        {
            _con.Close();
            SqlCommand cmd = new SqlCommand("Select * from Ogretmen", _con);
            _con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
           
            return reader;
        }
        public SqlDataReader ListeleAd(string ad)
        {
            SqlCommand cmd = new();
            if (ad == null)
            {
                Console.WriteLine("Değer  bulunamadı");
            }
            else
            {
                cmd = new SqlCommand($"Select * from Ogretmen where Ad Like '%{ad}%'", _con);
            }
            _con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            _con.Close();
            return reader;
        }
        public void Delete(int id)
        {
            _con.Close();
            SqlCommand cmd = new SqlCommand();
            if (id == null)
            {
                Console.WriteLine("Bir Id parametresi giriniz");
            }
            else
            {
                 cmd = new SqlCommand($"Delete From Ogretmen where Id={id}", _con);

            }
            _con.Open();
            cmd.ExecuteNonQuery();
           
        }
    }
}
