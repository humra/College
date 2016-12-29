CREATE DATABASE FarmaKrava
GO

USE FarmaKrava
GO

CREATE TABLE Pasmina
(
	ID int PRIMARY KEY IDENTITY(1, 1),
	Naziv nvarchar(100) NOT NULL UNIQUE
)
GO

CREATE TABLE Krava
(
	ID int PRIMARY KEY IDENTITY(1, 1),
	Ime nvarchar(50) NOT NULL,
	Pasmina int FOREIGN KEY (Pasmina) REFERENCES Pasmina(ID),
	DatumRodjenja date NOT NULL,
	VeterinarskiBroj nvarchar(20) NOT NULL CHECK(VeterinarskiBroj LIKE 'HR%') UNIQUE,
	BrojTeladi int NOT NULL
)
GO

CREATE TABLE ProizvodnaMlijeka
(
	ID int PRIMARY KEY IDENTITY(1, 1),
	KravaID int FOREIGN KEY (KravaID) REFERENCES Krava(ID) NOT NULL,
	Datum date NOT NULL,
	KolicinaMlijeka int NOT NULL,
	ProsjecniPostotakMasnoce float NOT NULL,
	ProsjecniPostotakMikroorganizama float NOT NULL
)
GO

INSERT INTO Pasmina (Naziv)
VALUES ('Simentalska'), ('Holstein'), ('Domaca obicna')
GO

INSERT INTO Krava (Ime, Pasmina, DatumRodjenja, VeterinarskiBroj, BrojTeladi)
VALUES ('Krava1', 1, '2015-10-22', 'HR00001', 2), ('Krava2', 2, '2015-02-12', 'HR00002', 3),
('Krava3', 3, '2014-02-02', 'HR00003', 1), ('Krava4', 2, '2014-08-30', 'HR00004', 1),
('Krava5', 3, '2015-01-18', 'HR00005', 5)
GO

INSERT INTO ProizvodnaMlijeka (KravaID, Datum, KolicinaMlijeka, ProsjecniPostotakMasnoce, ProsjecniPostotakMikroorganizama)
VALUES (1, '2016-12-20', 40, 2.6, 1.5), (1, '2016-12-21', 30, 2.2, 1.4), (2, '2016-12-20', 36, 2.2, 1.8), (2, '2016-12-21', 24, 2.0, 1.1),
(3, '2016-12-20', 24, 1.6, 1.5), (3, '2016-12-21', 40, 2.3, 1.0), (4, '2016-12-20', 12, 2.6, 1.5), (4, '2016-12-21', 22, 2.6, 1.5), 
(5, '2016-12-20', 24, 1.4, 0.7), (5, '2016-12-21', 8, 1.4, 1.1)
GO

ALTER TABLE Krava
ADD Slika nvarchar(500)
GO