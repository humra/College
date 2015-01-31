USE AdventureWorksOBP
GO

----Zadatak 1.
CREATE TABLE Osoba 
(
	IDOsoba int PRIMARY KEY IDENTITY(1, 1),
	Ime nvarchar(50),
	Prezime nvarchar(50)
)

BEGIN TRAN
SELECT @@TRANCOUNT
INSERT INTO Osoba (Ime, Prezime) VALUES ('Matija', 'Derk')
INSERT INTO Osoba (Ime, Prezime) VALUES ('Edo', 'Horvat')
INSERT INTO Osoba (Ime, Prezime) VALUES ('Matija', 'Huremovic')
ROLLBACK

----Zadatak 2.
BEGIN TRAN
SELECT @@TRANCOUNT
INSERT INTO Osoba (Ime, Prezime) VALUES ('Matija', 'Derk')
INSERT INTO Osoba (Ime, Prezime) VALUES ('Edo', 'Horvat')
INSERT INTO Osoba (Ime, Prezime) VALUES ('Matija', 'Huremovic')
COMMIT

----Zadatak 3.
BEGIN TRAN
INSERT INTO Osoba (Ime, Prezime) VALUES ('Pero', 'Peric')
SAVE TRAN s1
INSERT INTO Osoba (Ime, Prezime) VALUES ('Miro', 'Miric')
ROLLBACK

----Zadatak 4.
BEGIN TRAN
INSERT INTO Osoba (Ime, Prezime) VALUES ('Pero', 'Peric')
SAVE TRAN s1
INSERT INTO Osoba (Ime, Prezime) VALUES ('Miro', 'Miric')
COMMIT TRAN

----Zadatak 5.
BEGIN TRAN
INSERT INTO Osoba (Ime, Prezime) VALUES ('Pero', 'Peric')
SAVE TRAN s1
INSERT INTO Osoba (Ime, Prezime) VALUES ('Miro', 'Miric')
SAVE TRAN s2
ROLLBACK

----Zadatak 6.
BEGIN TRAN
INSERT INTO Osoba (Ime, Prezime) VALUES ('Pero', 'Peric')
SAVE TRAN s1
INSERT INTO Osoba (Ime, Prezime) VALUES ('Miro', 'Miric')
SAVE TRAN s2
COMMIT

----Zadatak 7.
BEGIN TRAN
INSERT INTO Osoba (Ime, Prezime) VALUES ('Ana', 'Anic')
SAVE TRAN s1
INSERT INTO Osoba (Ime, Prezime) VALUES ('Pero', 'Peric')
ROLLBACK TRAN s1
ROLLBACK

----Zadatak 8.
BEGIN TRAN
INSERT INTO Osoba (Ime, Prezime) VALUES ('Iva', 'Ivic')
SAVE TRAN s1
INSERT INTO Osoba (Ime, Prezime) VALUES ('Ana', 'Anic')
ROLLBACK TRAN s1
COMMIT
GO

----Zadatak 9.
CREATE PROC BrisanjeDrzave
@vrijednost int
AS
DELETE FROM Drzava WHERE Drzava.IDDrzava = @vrijednost
GO

BEGIN TRY
	BEGIN TRAN
		EXEC BrisanjeDrzave 50
		EXEC BrisanjeDrzave 51
		EXEC BrisanjeDrzave 52
	COMMIT TRAN
	PRINT 'Brisanje uspješno'
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	PRINT 'Greška pri brisanju'
END CATCH
GO


BEGIN TRY
	BEGIN TRAN
		EXEC BrisanjeDrzave 50
		EXEC BrisanjeDrzave 51
		EXEC BrisanjeDrzave 1
	COMMIT TRAN
	PRINT 'Brisanje uspješno'
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	PRINT 'Greška pri brisanju'
END CATCH
GO


----Zadatak 10.
CREATE PROC BrisanjeDrzava2
@prvi int, @drugi int, @treci int
AS
	BEGIN TRY
		BEGIN TRAN
		DELETE FROM Drzava WHERE IDDrzava IN (@prvi, @drugi, @treci)
		COMMIT
		PRINT 'Uspjesno izbrisano'
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT 'Greska pri brisanju'
	END CATCH
GO

EXEC BrisanjeDrzava2 50, 51, 52
EXEC BrisanjeDrzava2 50, 51, 1


----Zadatak 12.
BEGIN TRAN
EXEC BrisanjeDrzava2 50, 51, 52
ROLLBACK