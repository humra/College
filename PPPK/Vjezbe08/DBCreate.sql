CREATE DATABASE PPPKVjezbe08
GO

USE PPPKVjezbe08
GO

CREATE TABLE Drzava
(
	IDDrzava int PRIMARY KEY IDENTITY(1, 1),
	Naziv nvarchar(max)
)
GO

CREATE TABLE Grad
(
	IDGrad int PRIMARY KEY IDENTITY(1, 1),
	DrzavaID int FOREIGN KEY REFERENCES Drzava (IDDrzava),
	Naziv nvarchar(max), 
	BrStanovnika int
)
GO

INSERT INTO Drzava (Naziv)
VALUES ('Hrvatska'), ('Engleska'), ('Njemacka')
GO

INSERT INTO Grad (DrzavaID, Naziv, BrStanovnika)
VALUES (1, 'Zagreb', 400000), (1, 'Rijeka', 50000), (2, 'London', 4000000), (2, 'Cambridge', 2500000),
(3, 'Munchen', 5000000), (3, 'Stuttgart', 1750000)
GO