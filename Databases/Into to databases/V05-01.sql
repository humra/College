CREATE DATABASE Hotel
GO

USE Hotel

CREATE TABLE Hotel
(	HotelID	int	IDENTITY(1, 1) PRIMARY KEY,
	Zvjezdice	int	NOT NULL DEFAULT 3,
	Naziv	nvarchar(50)	NOT NULL,
	Adresa	nvarchar(100)	NOT NULL,
	CHECK (Zvjezdice BETWEEN 1 AND 5)
);

CREATE TABLE Soba
(	SobaID int IDENTITY(1, 1) PRIMARY KEY,
	Oznaka	nvarchar(10)	NOT NULL,
	Kreveti	int	NOT NULL,
	UHotelu	int	NOT NULL,
	CHECK (Kreveti < 5),
	FOREIGN KEY (UHotelu) REFERENCES Hotel (HotelID)
);

CREATE TABLE Gost
(	GostID int	IDENTITY(1, 1) PRIMARY KEY,
	Ime	nvarchar(50)	NOT NULL,
	Prezime	nvarchar(50)	NOT NULL,
	Soba	int	NOT NULL,
	FOREIGN KEY (Soba) REFERENCES Soba (SobaID)
);