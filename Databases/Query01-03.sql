CREATE DATABASE AutoKuca
GO

USE AutoKuca

CREATE TABLE Kupac
(	KupacID	int	IDENTITY(1, 1) PRIMARY KEY,
	Ime		nvarchar(50)	NOT NULL,
	Prezime		nvarchar(50)	NOT NULL,
	Kontakt		nvarchar(50)	NOT NULL
);

CREATE TABLE Automobil
(	AutoID		int	IDENTITY(1, 1) PRIMARY KEY,
	Proizvodjac	nvarchar(30)	NOT NULL,
	Model		nvarchar(30)	NOT NULL,
	Cijena		money	NOT NULL
);

CREATE TABLE RezervniDio
(	DioID		int	IDENTITY(1, 1) PRIMARY KEY,
	Proizvodjac	nvarchar(30)	NOT NULL,
	Model		nvarchar(30)	NOT NULL
);

CREATE TABLE Servis
(	ServisID	int	IDENTITY(1, 1) PRIMARY KEY,
	AutoID	int	NOT NULL,
	Vlasnik	int	NOT NULL,
	FOREIGN KEY (Vlasnik) REFERENCES Kupac (KupacID)
);

CREATE TABLE Prodaja
(	ProdajaID	int	IDENTITY(1, 1) PRIMARY KEY,
	Kupac		int	NOT NULL,
	Automobil	int	NULL,
	RezDio		int	NULL,
	Cijena		money	NOT NULL,
	FOREIGN KEY (Kupac) REFERENCES Kupac (KupacID),
	FOREIGN KEY (Automobil) REFERENCES Automobil (AutoID),
	FOREIGN KEY (RezDio) REFERENCES RezervniDio (DioID)
);