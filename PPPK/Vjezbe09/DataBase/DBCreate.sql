use master
go

create database PPPKVjezbe09
go

USE PPPKVjezbe09
GO

CREATE TABLE Automobil
(
	idAutomobil int identity not null primary key,
	Tip nvarchar(50),
	Proizvodjac nvarchar(50),
	Godina int,
	Ks int
)
GO

INSERT INTO Automobil VALUES('A4', 'Audi', 2003, 157)
INSERT INTO Automobil VALUES('Golf GTI', 'Volkswagen', 2005, 189)
INSERT INTO Automobil VALUES('Focus', 'Ford', 2000, 140)
INSERT INTO Automobil VALUES('M3', 'BMW', 2002, 190)
GO


CREATE PROCEDURE [dbo].[DohvatiAuto]
	@id int
AS
	SELECT * FROM Automobil WHERE idAutomobil=@id
GO


CREATE PROCEDURE [dbo].[InsertAuto]
	@tip nvarchar(50),
	@proizvodjac nvarchar(50),
	@godina int,
	@ks int
AS
	IF NOT EXISTS(SELECT * FROM Automobil where Tip=@tip and Proizvodjac=@proizvodjac and Godina=@godina and Ks=@ks) 
	BEGIN 
		INSERT INTO Automobil VALUES(@tip, @proizvodjac, @godina, @ks)
	END 
GO

CREATE PROCEDURE [dbo].[DeleteAuto]
	@id int
AS
	DELETE FROM Automobil WHERE idAutomobil=@id
GO

CREATE PROCEDURE DohvatiBrojUpisanihAutomobila
	
AS
	SELECT COUNT(*) FROM Automobil
GO


CREATE PROCEDURE [dbo].[DohvatiSveAutomobile]
AS
	SELECT idAutomobil, Tip FROM Automobil
GO

CREATE PROCEDURE [dbo].[UpdateAuto]
	@id int,
	@tip nvarchar(50),
	@proizvodjac nvarchar(50),
	@godina int,
	@ks int

AS
	UPDATE Automobil SET Tip=@tip, Proizvodjac=@proizvodjac, Godina=@godina, Ks=@ks WHERE idAutomobil=@id
GO