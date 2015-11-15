CREATE DATABASE PPPKVjezbe07
GO

USE PPPKVjezbe07
GO

CREATE TABLE Vozac
(
	ID int PRIMARY KEY IDENTITY(1, 1),
	Ime nvarchar(50) NOT NULL,
	Prezime nvarchar(50) NOT NULL
)
GO

CREATE TABLE Bolid
(
	ID int PRIMARY KEY IDENTITY(1, 1),
	IDVozac int FOREIGN KEY REFERENCES Vozac (ID),
	Naziv nvarchar(50) NOT NULL
)
GO

INSERT INTO Vozac (Ime, Prezime)
VALUES ('Matija', 'Huremovic'), ('Darth', 'Vader'),
('Tom Marvolo', 'Riddle'), ('E', 'Nigma'),
('James', 'Howlett')
GO

INSERT INTO Bolid(IDVozac, Naziv)
VALUES (1, 'Bolid1'), (1, 'Bolid2'), (2, 'Bolid3'),
(2, 'Bolid4'), (2, 'Bolid5'), (3, 'Bolid6'), (4, 'Bolid7'),
(5, 'Bolid8'), (5, 'Bolid9')
GO

CREATE PROCEDURE DohvatiSveTablice
AS
	SELECT * FROM Vozac
	SELECT * FROM Bolid
GO

CREATE PROCEDURE DodajBolid
@IDVozac int,
@Naziv nvarchar(50)
AS
	INSERT INTO Bolid (IDVozac, Naziv)
	VALUES (@IDVozac, @Naziv)
GO

CREATE PROCEDURE UpdateBolid
@ID int,
@Naziv nvarchar(50)
AS
	UPDATE Bolid SET Naziv = @Naziv WHERE ID = @ID
GO

CREATE PROCEDURE BrisiBolid
@ID int
AS
	DELETE FROM Bolid WHERE ID = @ID
GO

CREATE TABLE Automobil
(
	IDAutomobil int PRIMARY KEY IDENTITY(1, 1),
	Proizvodjac nvarchar(50) NOT NULL,
	Tip nvarchar(50) NOT NULL,
	Godina smallint NOT NULL,
	KS smallint NOT NULL
)
GO

INSERT INTO Automobil (Proizvodjac, Tip, Godina, KS) 
VALUES ('Golf','VW','2010','135'), ('A4','Audi','2003','157'),
('M3','BMW','2005','205'), ('Corsa','Opel','2001','55')
GO