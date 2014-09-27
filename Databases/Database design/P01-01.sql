USE AdventureWorksOBP

--1.
SELECT Ime, Prezime
FROM Kupac
INNER JOIN Grad ON IDGrad = GradID
WHERE Ime IN ('Tamara', 'Ana')
AND Naziv = 'Osijek'

--2.
INSERT INTO Kategorija
VALUES ('Razno')
INSERT INTO Potkategorija
VALUES (5, 'Playeri')
INSERT INTO Proizvod
VALUES ('Sony Player', 'HU-4242', 'Crna', 50, 985.50, 38)

--3.
CREATE TABLE KupacVIP
(
	IDKupac int CONSTRAINT PK_IDKupac PRIMARY KEY IDENTITY,
	Ime nvarchar(50) NOT NULL,
	Prezime nvarchar(50) NOT NULL
)
INSERT INTO KupacVIP
SELECT Ime, Prezime
FROM Kupac
WHERE Kupac.Ime IN ('Karen', 'Mary', 'Jimmy')

--4.
UPDATE Kupac
SET Email = 'nepoznato@nepoznato.com'
WHERE IDKupac BETWEEN 40 AND 42

--5.
DELETE FROM Kupac
WHERE Prezime = 'Trtimirović'

--6.
SELECT Kupac.Ime, Kupac.Prezime, Grad.Naziv AS Grad, Drzava.Naziv AS Drzava
FROM Kupac
INNER JOIN Grad ON GradID = IDGrad
INNER JOIN Drzava ON IDDrzava = DrzavaID

--7.
SELECT DISTINCT Naziv
FROM Proizvod
INNER JOIN Stavka ON ProizvodID = IDProizvod
WHERE Kolicina > 35

--8.
SELECT Naziv
FROM Proizvod
LEFT OUTER JOIN Stavka ON ProizvodID = IDProizvod
WHERE Stavka.ProizvodID IS NULL

--9.
SELECT Drzava.Naziv, Grad.Naziv
FROM Drzava
FULL OUTER JOIN Grad ON Grad.DrzavaID = Drzava.IDDrzava
WHERE DrzavaID IS NULL
OR IDDrzava IS NULL

--10.
SELECT Naziv, ISNULL(Boja, 'NIJE DEFINIRANO')
FROM Proizvod

--11.
SELECT AVG(CijenaBezPDV) AS Average
FROM Proizvod
WHERE PotkategorijaID = 16

--12.
SELECT MAX(DatumIzdavanja) AS Newest, MIN(DatumIzdavanja) AS Oldest
FROM Racun
WHERE KupacID = 131

--13.
SELECT Boja, COUNT(*) AS BrojProizvoda
FROM Proizvod
GROUP BY Boja

--14.
SELECT DATEPART(YEAR, DatumIzdavanja) AS Year, COUNT(*) AS Amount
FROM Racun
GROUP BY DATEPART(YEAR, DatumIzdavanja)

--15.
SELECT SUM(UkupnaCijena) AS TotalValue , Proizvod.Naziv
FROM Stavka
INNER JOIN Proizvod	ON ProizvodID = IDProizvod
GROUP BY Naziv
HAVING SUM(Kolicina) > 2000

--16.
SELECT TOP 5 Ime, Prezime, (SELECT COUNT(IDRacun)
							FROM Racun
							WHERE IDKomercijalist = KomercijalistID) AS Amount
FROM Komercijalist
ORDER BY Amount DESC

--17.
SELECT DISTINCT Boja, 
			(SELECT COUNT (*)
			FROM Proizvod AS p2
			WHERE ISNULL(p1.Boja, 'NONE') = ISNULL(p2.Boja, 'NONE')) AS Amount
FROM Proizvod AS p1

--18.
SELECT Naziv
FROM Proizvod
WHERE IDProizvod NOT IN(SELECT ProizvodID FROM Stavka)

SELECT Naziv
FROM Proizvod
WHERE NOT EXISTS(SELECT * FROM Stavka WHERE IDProizvod = ProizvodID)