CREATE DATABASE BazaDOO
GO

USE BazaDOO

CREATE TABLE PoslovniPartner 
(	PartnerID	int		IDENTITY(1, 1) PRIMARY KEY,
	Ime		nvarchar(max)	NOT NULL,
	MaticniBroj	nvarchar(20)	NOT NULL,
	Telefon		nvarchar(20)	NULL,
	Fax		nvarchar(20)	NULL
);

CREATE TABLE Zaposlenik
(	ZaposlenikID	int		IDENTITY(1, 1) PRIMARY KEY,
	Ime		nvarchar(50)	NOT NULL,
	Prezime		nvarchar(50)	NOT NULL,
	Telefon		nvarchar(20)	NULL,
	Mail		nvarchar(50)	NULL,
	ZaposlenU	int	NOT NULL,
	FOREIGN KEY (ZaposlenU) REFERENCES PoslovniPartner (PartnerID)
);