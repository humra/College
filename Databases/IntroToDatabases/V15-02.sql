USE AdventureWorksOBP

SELECT Boja, SUM(UkupnaCijena) AS Earned
FROM Proizvod
INNER JOIN Stavka ON ProizvodID = Proizvod.IDProizvod
GROUP BY Boja
HAVING SUM(UkupnaCijena) > 20000000

SELECT Proizvod.Naziv, COUNT(IDProizvod), Kategorija.Naziv
FROM Proizvod
INNER JOIN Potkategorija ON PotkategorijaID = IDPotkategorija
INNER JOIN Stavka ON ProizvodID = IDProizvod
INNER JOIN Kategorija ON KategorijaID = Kategorija.IDKategorija
WHERE PotkategorijaID IS NOT NULL
GROUP BY Proizvod.Naziv, Kategorija.Naziv
HAVING COUNT(IDProizvod) > 500

SELECT Proizvod.Naziv, SUM(UkupnaCijena) AS TotalPrice, COUNT(ProizvodID) AS Sold
FROM Proizvod
INNER JOIN Stavka ON ProizvodID = Proizvod.IDProizvod
GROUP BY Proizvod.Naziv

SELECT Proizvod.Naziv, SUM(UkupnaCijena) AS TotalPrice
FROM Proizvod
INNER JOIN Stavka ON ProizvodID = IDProizvod
GROUP BY Proizvod.Naziv
HAVING Count(ProizvodID) > 2000

SELECT Proizvod.Naziv, SUM(UkupnaCijena)
FROM Proizvod
INNER JOIN Stavka ON ProizvodID = IDProizvod
GROUP BY Proizvod.Naziv
HAVING SUM(UkupnaCijena) > 2000000 OR
COUNT(ProizvodID) > 2000