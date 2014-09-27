--CREATE DATABASE RentACar

USE RentACar

CREATE TABLE StatusVozila
(
	IDStatusVozila int CONSTRAINT PK_IDStatusVozila PRIMARY KEY IDENTITY,
	Naziv nvarchar(50) NOT NULL
)

CREATE TABLE Kategorija
(
	IDKategorija int CONSTRAINT PK_IDKategorija PRIMARY KEY IDENTITY,
	Naziv nvarchar(50) NOT NULL
)

CREATE TABLE Proizvodjac
(
	IDProizvodjac int CONSTRAINT PK_IDProizvodjac PRIMARY KEY IDENTITY,
	Naziv nvarchar(50) NOT NULL
)

CREATE TABLE Klijent
(
	IDKlijent int CONSTRAINT PK_IDKlijent PRIMARY KEY IDENTITY,
	Ime nvarchar(50) NOT NULL,
	Prezime nvarchar(50) NOT NULL,
	EMail nvarchar(50) NOT NULL,
	Telefon nvarchar(50) NOT NULL,
	Adresa nvarchar(50) NOT NULL,
	Grad nvarchar(50) NOT NULL,
	Drzava nvarchar(50) NOT NULL
)
	
CREATE TABLE Model
(
	IDModel int CONSTRAINT PK_IDModel PRIMARY KEY IDENTITY,
	Naziv nvarchar(50) NOT NULL,
	IDProizvodjac int REFERENCES Proizvodjac(IDProizvodjac)
)

CREATE TABLE Vozilo
(
	IDVozilo int CONSTRAINT PK_IDVozilo PRIMARY KEY IDENTITY,
	Registracija nvarchar(20) NOT NULL,
	ModelID int REFERENCES Model(IDModel),
	KategorijaID int REFERENCES Kategorija(IDKategorija),
	Kilometraza int NOT NULL,
	CijenaPoDanu money NOT NULL
)

CREATE TABLE Najam
(
	IDNajam int CONSTRAINT PK_IDNajam PRIMARY KEY IDENTITY,
	StatusVozilaID int REFERENCES StatusVozila(IDStatusVozila),
	KlijentID int REFERENCES Klijent(IDKlijent),
	VoziloID int REFERENCES Vozilo(IDVozilo),
	DatumOd datetime NOT NULL,
	DatumDo datetime NOT NULL
)