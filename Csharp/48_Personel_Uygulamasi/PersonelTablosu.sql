Create database PersonelUygulama
go
Use PersonelUygulama
go
Create Table Personel(
Id int Primary key Identity(1,1),
Isim varchar(50),
Soyisim varchar(50),
Email varchar(50),
Telefon varchar(13),
)
create table SistemKullanici
(
Id int primary key identity(1,1),
KullaniciAdi varchar(50),
Sifre varchar(50)
)