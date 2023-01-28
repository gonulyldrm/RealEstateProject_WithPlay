create database emlakisleri
go
use emlakisleri
go
create table üyeler
(
	Id int identity,
	adsoyad varchar(200),
	telefon varchar(12),
	kullanýcýadý varchar(100),
	email varchar(80),
	sifre varchar(60),
	sehir varchar(50),
	puan varchar(50),
	constraint pk_üyeler_Id primary key(Id)
)
go
create table yöneticiler
(
	Id int identity,
	adsoyad varchar(200),
	telefon varchar(12),
	kullanýcýadý varchar(100),
	email varchar(80),
	sifre varchar(60),
	sehir varchar(80),
	onaykodu int,
	constraint pk_yöneticiler_Id primary key(Id)
)
go
create table editörler
(
	Id int identity,
	adsoyad varchar(200),
	telefon varchar(12),
	kullanýcýadý varchar(100),
	email varchar(80),
	sifre varchar(60),
	sehir varchar(80),
	onaykodu int,
	constraint pk_editörler_Id primary key(Id)
)
go
create table sorular
(
	 
	soru varchar(1000),
	a varchar(12),
	b varchar(100),
	c varchar(80),
	d varchar(60),
	dogru varchar(60)
	
)
go
create table ürünler
(
	 
	Id int  ,
	adres varchar(500),
	fiyat int,
	puan int,
	acýklama varchar(5000),
	resim1 varchar(600),
	resim2 varchar(600)
	
)
go
create table silinecekler
(
	 
	Id int  ,
	adres varchar(500),
	fiyat int,
	puan int,
	acýklama varchar(5000),
	resim1 varchar(600),
	resim2 varchar(600)
	
)
go
create table eklenecekler
(
	 
	Id int  ,
	adres varchar(500),
	fiyat int,
	puan int,
	acýklama varchar(5000),
	resim1 varchar(600),
	resim2 varchar(600)
	
)
go
create table sikayetler
(
	 
	sikayet varchar(600)
	
)
go
create table satilanlar
(
	Id int identity,
	adsoyad varchar(50),
	kullaniciadi varchar(100),
	email varchar(80),
	sifre varchar(60),
	urunId varchar(600),
	kredikart varchar(60),
	guvenlik varchar(50),
	yil int,
	ay int,
	gun int
	constraint pk_satilanlar_Id primary key(Id)
)
go
create table kiralananlar
(
	Id int identity,
	adsoyad varchar(50),
	kullaniciadi varchar(100),
	email varchar(80),
	sifre varchar(60),
	urunId varchar(600),
	kredikart varchar(60),
	guvenlik varchar(50),
	yil int,
	ay int,
	gun int
	constraint pk_kiralananlar_Id primary key(Id)
)
go

