USE AdventureWorksOBP

SELECT Boja
FROM Proizvod
GROUP BY Boja
HAVING COUNT(Boja) > 40;

SELECT Potkategorija.Naziv
FROM Potkategorija
INNER JOIN Proizvod ON PotkategorijaID = IDPotkategorija
GROUP BY Potkategorija.Naziv
HAVING COUNT(PotkategorijaID) > 10;

SELECT DISTINCT Proizvod.Naziv, UkupnaCijena,
COUNT (ProizvodID) AS AmountSold
FROM Stavka
INNER JOIN Proizvod ON ProizvodID = IDProizvod
GROUP BY ProizvodID, UkupnaCijena, Proizvod.Naziv;

SELECT DISTINCT Proizvod.Naziv, UkupnaCijena,
COUNT (ProizvodID) AS AmountSold
FROM Stavka
INNER JOIN Proizvod ON ProizvodID = IDProizvod
GROUP BY ProizvodID, UkupnaCijena, Proizvod.Naziv
HAVING COUNT (ProizvodID) > 2000;

SELECT DISTINCT Proizvod.Naziv, UkupnaCijena,
COUNT (ProizvodID) AS AmountSold
FROM Stavka
INNER JOIN Proizvod ON ProizvodID = IDProizvod
GROUP BY ProizvodID, UkupnaCijena, Proizvod.Naziv
HAVING COUNT (ProizvodID) > 2000 OR
UkupnaCijena > 2000000;