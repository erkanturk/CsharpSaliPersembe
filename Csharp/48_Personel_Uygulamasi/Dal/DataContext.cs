using _48_Personel_Uygulamasi.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48_Personel_Uygulamasi.Dal
{
    public class DataContext
    {
        SqlConnection _con;
        SqlCommand _cmd;
        SqlDataReader _reader;
        int sonuc = 0;

        public DataContext()//Constructor
        {
            _con = new SqlConnection("Data Source=204-HOCAPC1;Initial Catalog=PersonelUygulama;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
            _cmd = new SqlCommand();
        }

        public void BaglantiAyarla()
        {
            if (_con.State == System.Data.ConnectionState.Closed)
            {
                _con.Open();
                Console.WriteLine("Ok");
            }
            else
            {
                _con.Close();
            }
        }
        public int SistemGirisKontrol(SistemKullanici kullanici)
        {
            try
            {
                _cmd =new SqlCommand($"Select * From SistemKullanici where KullaniciAdi='{kullanici.KullaniciAdi}' and Sifre={kullanici.Sifre}", _con);
                _con.Open();
                _reader = _cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (_reader.Read())
                {
                    sonuc = 1;
                }
                _con.Close();
            }
            return sonuc;
        }
        public int PersonelKayit(Personel personel)
        {
            _cmd = new SqlCommand($"Insert into personel (Isim,Soyisim,Email,Telefon) " +
                $"values('{personel.Isim}','{personel.SoyIsim}','{personel.Email}','{personel.Telefon}')", _con);
            BaglantiAyarla();
            sonuc = _cmd.ExecuteNonQuery();
            BaglantiAyarla();
            return sonuc;
        }
        public bool UniqueEmailPhone(string email, string telefon)
        {
            _cmd = new SqlCommand($"Select * From Personel where Email='{email}' or Telefon={telefon}", _con);
            BaglantiAyarla();
            _reader= _cmd.ExecuteReader();
            if (_reader.Read())
            {
                BaglantiAyarla();
                return true;
            }
            else
            {
                BaglantiAyarla();
                return false;
            }
        }
        public int PersonelGuncelle(Personel p)
        {
            try
            {
                _cmd = new SqlCommand($"Update Personel set Isim=@isim,Soyisim=@soyisim,Email=@email,Telefon=@telefon where Id=@id", _con);
                _cmd.Parameters.AddWithValue("@isim", p.Isim);
                _cmd.Parameters.AddWithValue("@soyisim", p.SoyIsim);
                _cmd.Parameters.AddWithValue("@email", p.Email);
                _cmd.Parameters.AddWithValue("@telefon", p.Telefon);
                _cmd.Parameters.AddWithValue("@id", p.Id);
                BaglantiAyarla();
                return _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
                throw;

            }
            finally
            {
                BaglantiAyarla();
            }
        }
        public int PersonelSil(int id)
        {
            try
            {
                _cmd = new SqlCommand("Delete from personel where Id =@id", _con);
                _cmd.Parameters.AddWithValue("@id", id);
                BaglantiAyarla();
                return _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
        }
        public SqlDataReader PersonelListele()
        {
            try
            {
                _cmd = new SqlCommand($"Select * from Personel", _con);
                BaglantiAyarla();
                return _cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
                throw;
            }
        }
    }
}
