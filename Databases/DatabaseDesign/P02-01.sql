CREATE VIEW Proizvodi AS
SELECT *
FROM Proizvod
GO

ALTER VIEW Proizvodi AS
SELECT * 
FROM Proizvod
WHERE PotkategorijaID = 13
GO

ALTER VIEW Proizvodi AS
SELECT TOP 100 PERCENT Boja, COUNT(*) AS Kolicina
FROM Proizvod
GROUP BY Boja
ORDER BY Kolicina DESC
GO

ALTER VIEW Proizvodi AS
SELECT Proizvod.Naziv AS Proizvod, Potkategorija.Naziv AS Potkategorija
FROM Proizvod
INNER JOIN Potkategorija ON PotkategorijaID = IDPotkategorija
GO

ALTER VIEW Proizvodi AS
SELECT IDProizvod, Naziv AS NazivProizvoda, 
BrojProizvoda, Boja,
MinimalnaKolicinaNaSkladistu, CijenaBezPDV,
PotkategorijaID
FROM Proizvod
GO

DROP VIEW Proizvodi
GO

CREATE VIEW ZaSefa AS
SELECT TOP 100 PERCENT Ime, Prezime, SUM(Kolicina) AS ProdanoProizvoda
FROM Komercijalist
INNER JOIN Racun ON KomercijalistID = IDKomercijalist
INNER JOIN Stavka ON RacunID = IDRacun
GROUP BY Ime, Prezime
ORDER BY ProdanoProizvoda DESC
GO

DROP VIEW ZaSefa
GO

CREATE VIEW KreditneKartice AS
SELECT *
FROM KreditnaKartica
WHERE Tip = 'Diners'
GO

ALTER VIEW KreditneKartice AS
SELECT *
FROM KreditnaKartica
WHERE Tip = 'Visa'
GO

DROP VIEW KreditneKartice
GO

CREATE VIEW Marketing AS
SELECT *
FROM Proizvod
WHERE (SELECT SUM(Kolicina) FROM Stavka WHERE ProizvodID = IDProizvod) > 2000
GO

ALTER VIEW Marketing AS
SELECT *, (SELECT SUM(Kolicina) FROM Stavka WHERE ProizvodID = IDProizvod) AS Prodano
FROM Proizvod
WHERE (SELECT SUM(Kolicina) FROM Stavka WHERE ProizvodID = IDProizvod) > 2000
GO

DROP VIEW Marketing