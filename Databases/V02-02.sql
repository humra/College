CREATE DATABASE LosFilm
GO

USE LosFilm

CREATE TABLE Clan
(	ClanID	int		IDENTITY(1, 1) PRIMARY KEY,
	Ime	nvarchar(50)	NOT NULL,
	Prezime	nvarchar(50)	NOT NULL,
	Kontakt	nvarchar(20)	NOT NULL,
	Adresa	nvarchar(100)	NULL
);

CREATE TABLE Medij
(	MedijID	int	IDENTITY(1, 1) PRIMARY KEY,
	TipMedija	nvarchar(10)	NOT NULL,
	Naziv		nvarchar(50)	NOT NULL,
	GlGlumac	nvarchar(100)	NULL,
	SpGlumac	nvarchar(100)	NULL,
	Trajanje	int	NOT NULL,
	Reziser		nvarchar(100)	NULL,
	Zanr		nvarchar(20)	NOT NULL,
	KratkiOpis	nvarchar(max)	NULL
);

CREATE TABLE Posudba
(	PosudbaID	int	IDENTITY(1, 1) PRIMARY KEY,
	Medij		int NOT NULL,
	Clan		int	NOT NULL,
	Posudjeno	date	NOT NULL,
	RokVracanja	date	NOT NULL,
	FOREIGN KEY (Medij) REFERENCES Medij (MedijID),
	FOREIGN KEY (Clan) REFERENCES Clan (ClanID)
);