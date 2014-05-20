CREATE DATABASE Microprodaja
GO

USE Microprodaja

CREATE TABLE ProdajnoMjesto
(	MjestoID	int	IDENTITY(1, 1) PRIMARY KEY,
	Proizvodi	nvarchar(30)	NOT NULL,
	Naziv		nvarchar(50)	NOT NULL,
	Adresa		nvarchar(100)	NOT NULL
);

CREATE TABLE Zaposlenik
(	ZaposlenikID	int	IDENTITY(1, 1) PRIMARY KEY,
	Ime		nvarchar(50)	NOT NULL,
	Prezime		nvarchar(50)	NOT NULL,
	Telefon		nvarchar(20)	NULL,
	RadiU		int	NOT NULL,
	FOREIGN KEY (RadiU) REFERENCES ProdajnoMjesto (MjestoID)
);

CREATE TABLE Proizvod
(	ProizvodID	int IDENTITY(1, 1) PRIMARY KEY,
	Naziv		nvarchar(50)	NOT NULL,
	Cijena		money	NOT NULL,
	MjestoProdaje	int	NOT NULL,
	FOREIGN KEY (MjestoProdaje) REFERENCES ProdajnoMjesto (MjestoID)
);

ALTER TABLE ProdajnoMjesto
ADD Voditelj int

ALTER TABLE ProdajnoMjesto
ADD FOREIGN KEY (Voditelj)
REFERENCES Zaposlenik (ZaposlenikID)