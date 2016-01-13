USE master
GO

CREATE DATABASE PPPKVjezbe10
GO

USE PPPKVjezbe10
GO

CREATE TABLE Drzava
(
	IDDrzava int PRIMARY KEY IDENTITY,
	Naziv nvarchar(50)
)
GO
CREATE TABLE Grad
(
	IDGrad int PRIMARY KEY IDENTITY,
	Naziv nvarchar(50),
	DrzavaID int REFERENCES Drzava(IDDrzava)
)
GO
INSERT INTO Drzava VALUES ('Hrvatska')
INSERT INTO Drzava VALUES ('Kina')
INSERT INTO Drzava VALUES ('Švicarska')
INSERT INTO Grad VALUES ('Zagreb', 1)
INSERT INTO Grad VALUES ('Rijeka', 1)
INSERT INTO Grad VALUES ('Zadar', 1)
INSERT INTO Grad VALUES ('Split', 1)
INSERT INTO Grad VALUES ('Šibenik', 1)
INSERT INTO Grad VALUES ('Osijek', 1)
INSERT INTO Grad VALUES ('Šangaj', 2)
INSERT INTO Grad VALUES ('Peking', 2)
INSERT INTO Grad VALUES ('Basel', 3)
INSERT INTO Grad VALUES ('Zurich', 3)
INSERT INTO Grad VALUES ('Luzern', 3)
GO

CREATE PROC GetAllGrad
AS
SELECT * FROM Grad
GO

CREATE PROC InsertGrad
	@Naziv nvarchar(50),
	@DrzavaID int
AS
INSERT INTO Grad VALUES (@Naziv, @DrzavaID)
SELECT * FROM Grad WHERE IDGrad = SCOPE_IDENTITY()
GO

CREATE PROC UpdateGrad
	@IDGrad int,
	@Naziv nvarchar(50),
	@DrzavaID int
AS
UPDATE Grad SET Naziv = @Naziv, DrzavaID = @DrzavaID WHERE IDGrad = @IDGrad
GO

CREATE PROC DeleteGrad
	@IDGrad int
AS
DELETE FROM Grad WHERE IDGrad = @IDGrad
GO

