USE AdventureWorksOBP

--Zadatak 1.
CREATE TYPE OsobeIds AS TABLE
(
	id int
)
GO

CREATE PROC KupciID
@idevi OsobeIds READONLY
AS
	SELECT * FROM Kupac
	WHERE Kupac.IDKupac IN (SELECT * FROM @idevi)
GO

DECLARE @osobe OsobeIds
INSERT INTO @osobe VALUES(1)
INSERT INTO @osobe VALUES(500)
INSERT INTO @osobe VALUES(10)
EXEC KupciID @osobe


--Zadatak 2.
CREATE TYPE MyDrzava AS TABLE
(
	Naziv nvarchar(50)
)
GO

CREATE PROC UmetanjeDrzava
@ulaz MyDrzava READONLY
AS
	INSERT INTO Drzava 
	SELECT * FROM @ulaz
GO

DECLARE @unos MyDrzava
INSERT INTO @unos VALUES ('Indija')
INSERT INTO @unos VALUES ('Pakistan')
EXEC UmetanjeDrzava @unos

SELECT * FROM Drzava


--Zadatak 3.
CREATE TYPE MyPotkategorija AS TABLE
(
	KategorijaID int,
	Naziv nvarchar(50)
)
GO

CREATE PROC UmetniPotkategorije
@ulaz MyPotkategorija READONLY
AS
	INSERT INTO Potkategorija
	SELECT KategorijaID, Naziv FROM @ulaz WHERE Naziv NOT IN (SELECT Naziv FROM Potkategorija)
GO

DECLARE @ulaz MyPotkategorija
INSERT INTO @ulaz VALUES (1, 'Mountain Bikes')
INSERT INTO @ulaz VALUES (1, 'Ninja Bikes')
EXEC UmetniPotkategorije @ulaz

SELECT * FROM Potkategorija