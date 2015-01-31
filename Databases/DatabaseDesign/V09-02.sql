USE AdventureWorksOBP
GO

----Zadatak 1.
--CREATE PROC Nazivi
--@gradovi xml
--AS
--SELECT Tablica.stupac.value('.', 'nvarchar(max)') AS Grad
--FROM @gradovi.nodes('/Gradovi/Grad') AS Tablica(stupac)
--GO

--EXEC Nazivi '<Gradovi><Grad>Karlovac</Grad><Grad>Sisak</Grad><Grad>Kutina</Grad></Gradovi>'

----Zadatak 2.
--ALTER PROC Nazivi
--@gradovi xml
--AS
--SELECT Tablica.stupac.value('.', 'nvarchar(max)') AS Grad,
--Tablica.stupac.value('@Pbr', 'nvarchar(max)') AS PostanskiBroj
--FROM @gradovi.nodes('/Gradovi/Grad') AS Tablica(stupac)
--GO

--EXEC Nazivi '<Gradovi><Grad Pbr="10000">Zagreb</Grad><Grad Pbr="31000">Osijek</Grad></Gradovi>'

----Zadatak 3.
--ALTER PROC KupciGradovi
--@ulaz xml
--AS
--SELECT Tablica.Stupac.value('.', 'nvarchar(max)') AS Prezime
--FROM @ulaz.nodes('/Kupci/Kupac/Prezime') AS Tablica(Stupac)
--ORDER BY Prezime ASC

--SELECT DISTINCT Tablica.Stupac.value('.', 'nvarchar(max)') AS Gradovi
--FROM @ulaz.nodes('/Kupci/Kupac/Grad') AS Tablica(Stupac)
--GO

--EXEC KupciGradovi '
--	<Kupci>
--		<Kupac>
--			<Ime>Mirko</Ime>
--			<Prezime>Mirkiæ</Prezime>
--			<Grad>Osijek</Grad>
--		</Kupac>
--		<Kupac>
--			<Ime>Ana</Ime>
--			<Prezime>Aniæ</Prezime>
--			<Grad>Osijek</Grad>
--		</Kupac>
--	</Kupci>'

----Zadatak 4.
CREATE PROC Kupci
@ulaz xml
AS
	SELECT Tablica.Stupac.value('.', 'nvarchar(max)') AS Ime,
	Tablica.Stupac.value('@ID', 'nvarchar(max)') AS ID
	FROM @ulaz.nodes('/Osobe/Osoba') AS Tablica(Stupac)
GO

EXEC Kupci '<Osobe>
		<Osoba ID="1">Ana Aniæ</Osoba>
		<Osoba ID="35">Maja Majiæ</Osoba>
		<Osoba ID="158">Tanja Tanjiæ</Osoba>
		<Osoba ID="85002">Vera Veriæ</Osoba>
	</Osobe>'