USE AdventureWorksOBP

SELECT Boja, COUNT(*)
FROM Proizvod
GROUP BY Boja
HAVING COUNT(*) > 40

SELECT Potkategorija.Naziv, COUNT(*)
FROM Potkategorija
INNER JOIN Proizvod ON PotkategorijaID = Potkategorija.IDPotkategorija
GROUP BY Potkategorija.Naziv
HAVING COUNT(*) > 10

SELECT Proizvod.Naziv, SUM(UkupnaCijena), COUNT(*)
FROM Proizvod
INNER JOIN Stavka ON ProizvodID = IDProizvod
GROUP BY Proizvod.Naziv

SELECT Proizvod.Naziv, SUM(UkupnaCijena), COUNT(*)
FROM Proizvod
INNER JOIN Stavka ON ProizvodID = IDProizvod
GROUP BY Proizvod.Naziv
HAVING COUNT(*) > 2000

SELECT Proizvod.Naziv, SUM(UkupnaCijena), COUNT(*)
FROM Proizvod
INNER JOIN Stavka ON ProizvodID = IDProizvod
GROUP BY Proizvod.Naziv
HAVING COUNT(*) > 2000 OR
SUM(UkupnaCijena) > 2000000