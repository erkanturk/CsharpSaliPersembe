using _48_Personel_Uygulamasi.Dal;
using _48_Personel_Uygulamasi.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48_Personel_Uygulamasi.BLL
{
    public class BusinessLayer
    {
        DataContext _dal;
        SqlDataReader _reader;
        public BusinessLayer()
        {
            _dal = new DataContext();
        }
        public int SistemGirisKontrol(string kullaniciAdi, string sifre)
        {
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                return -100;
            }
            SistemKullanici sistemKullanici = new SistemKullanici()
            {
                KullaniciAdi = kullaniciAdi,
                Sifre = sifre
            };
            return _dal.SistemGirisKontrol(sistemKullanici);
        }
        public int PersonelKayit(string isim, string soyisim, string email, string telefon)
        {
            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
            {
                return -100;
            }
            bool uniqueEmail = _dal.UniqueEmailPhone(email, telefon);
            if (uniqueEmail)
            {
                return -101;
            }
            Personel personel = new Personel()
            {
                Isim = isim,
                SoyIsim = soyisim,
                Email = email,
                Telefon = telefon
            };
            return _dal.PersonelKayit(personel);
        }
        public List<Personel> PersonelListele()
        {
            List<Personel> personellerim = new List<Personel>();
            try
            {
                _reader = _dal.PersonelListele();
                while (_reader.Read())
                {
                    personellerim.Add(new Personel()
                    {
                        Id = _reader.GetInt32(0),
                        Isim = _reader.IsDBNull(1) ? string.Empty : _reader.GetString(1),
                        SoyIsim = _reader.IsDBNull(2) ? string.Empty : _reader.GetString(2),
                        Email = _reader.IsDBNull(3) ? string.Empty : _reader.GetString(3),
                        Telefon = _reader.IsDBNull(4) ? string.Empty : _reader.GetString(4)
                    });

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata" + ex.Message);
                throw;
            }
            finally
            {
                if (_reader != null && !_reader.IsClosed)
                {
                    _reader.Close();
                }
                _dal.BaglantiAyarla();
            }
            return personellerim;
        }
        public List<Personel1> PersonelListele1()
        {
            List<Personel1> personellerim = new List<Personel1>();
            try
            {
                _reader = _dal.PersonelListele();
                while (_reader.Read())
                {
                    personellerim.Add(new Personel1()
                    {
                        Id = _reader.GetInt32(0),
                        Isim = _reader.IsDBNull(1) ? string.Empty : _reader.GetString(1),
                        SoyIsim = _reader.IsDBNull(2) ? string.Empty : _reader.GetString(2),
                        Email = _reader.IsDBNull(3) ? string.Empty : _reader.GetString(3),
                        Telefon = _reader.IsDBNull(4) ? string.Empty : _reader.GetString(4)
                    });

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata" + ex.Message);
                throw;
            }
            finally
            {
                if (_reader != null && !_reader.IsClosed)
                {
                    _reader.Close();
                }
                _dal.BaglantiAyarla();
            }
            return personellerim;
        }
        public int PersonelGuncelle(int id, string isim, string soyisim, string email, string telefon)
        {
            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
            {
                return -100;
            }
            Personel personel = new Personel()
            {
                Id = id,
                Isim = isim,
                SoyIsim = soyisim,
                Email = email,
                Telefon = telefon
            };
            return _dal.PersonelGuncelle(personel);
        }
        public int PersonelSil(int id)
        {
            return _dal.PersonelSil(id);
        }
    }
}
