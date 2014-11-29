USE AdventureWorksOBP

----1.
--DECLARE @Ime nvarchar(50)
--DECLARE @Prezime nvarchar(50)

--SET @Ime = 'Matija'
--SET @Prezime = 'Huremovic'

--PRINT @Ime
--PRINT @Prezime

----2.
--SELECT @Ime = Ime,
--@Prezime = Prezime
--FROM Kupac
--WHERE Kupac.IDKupac = 8812

--PRINT @Ime
--PRINT @Prezime

----3.
--SELECT @Ime = Ime,
--@Prezime = Prezime
--FROM Kupac

--PRINT @Ime
--PRINT @Prezime

----4.
--DECLARE @BrojKupaca int

--SELECT @BrojKupaca = COUNT(*) 
--FROM Kupac

--IF @BrojKupaca >= 20000 BEGIN
--	PRINT 'Postoji vise od 20000 kupaca :)'
--END
--ELSE BEGIN
--	PRINT 'Nismo jos dostigli 20000 kupaca :('
--END

----5.
--DECLARE @ID int

--INSERT INTO Drzava (Naziv) VALUES ('Belgija')

--SET @ID = SCOPE_IDENTITY()

--PRINT @ID

----6.
--DECLARE @ID int

--INSERT INTO Drzava (Naziv) VALUES ('Rusija')

--SET @ID = SCOPE_IDENTITY()

--INSERT INTO Grad (Naziv, DrzavaID)
--VALUES ('Moskva', @ID),
--('St. Petersburg', @ID)

----7.
--CREATE PROC dbo.SveDrzave AS
--SELECT * 
--FROM Drzava

--EXEC dbo.SveDrzave

--ALTER PROC dbo.SveDrzave AS
--SELECT *
--FROM Drzava
--ORDER BY Naziv DESC

--DROP PROC dbo.SveDrzave

----8.
--CREATE PROC dbo.PrviRacuni AS
--SELECT TOP 5 *
--FROM Racun
--SELECT TOP 5 *
--FROM Proizvod
--SELECT TOP 5 * 
--FROM Stavka

--EXEC dbo.PrviRacuni

--DROP PROC dbo.PrviRacuni

----9.
--CREATE PROC dbo.ProizvodPoID 
--@ID int
--AS
--SELECT *
--FROM Proizvod
--WHERE Proizvod.IDProizvod = @ID

--EXEC dbo.ProizvodPoID 1

--EXEC dbo.ProizvodPoID @ID = 2

--DROP PROC dbo.ProizvodPoID

----10.
--CREATE PROC dbo.SaCijenom
--@Prva money, @Druga money
--AS
--SELECT *
--FROM Proizvod
--WHERE Proizvod.CijenaBezPDV BETWEEN @Prva AND @Druga

--EXEC dbo.SaCijenom 100, 200

--EXEC dbo.SaCijenom @Druga = 300, @Prva = 150

--DROP PROC dbo.SaCijenom

----11.
--CREATE PROC dbo.DrzavaGrad 
--@Drzava nvarchar(50), @Grad nvarchar(50)
--AS
--DECLARE @DID int
--SELECT @DID = IDDrzava
--FROM Drzava
--WHERE Drzava.Naziv = @Drzava
--IF @DID IS NULL BEGIN
--	INSERT INTO Drzava (Naziv)
--	VALUES (@Drzava)
--END
--SET @DID = SCOPE_IDENTITY()
--INSERT INTO Grad (Naziv, DrzavaID)
--VALUES (@Grad, @DID)


--EXEC dbo.DrzavaGrad  'Japan', 'Osaka'
--EXEC dbo.DrzavaGrad 'Japan', 'Tokyo'

--DROP PROC dbo.DrzavaGrad

--12.
