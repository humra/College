USE AdventureWorksOBP

SELECT Boja, COUNT(Boja)
FROM Proizvod
GROUP BY Boja

SELECT Boja, COUNT(Boja) AS Amount
FROM Proizvod
GROUP BY Boja
ORDER BY Amount DESC

SELECT Boja, COUNT(Boja) AS Amount
FROM Proizvod
WHERE Boja IS NOT NULL
GROUP BY Boja
ORDER BY Amount DESC

SELECT COUNT(Boja), Potkategorija.Naziv
FROM Proizvod
INNER JOIN Potkategorija ON IDPotkategorija = PotkategorijaID
GROUP BY Potkategorija.Naziv, Boja


SELECT TOP 10 COUNT(Boja) AS Amount, Potkategorija.Naziv
FROM Proizvod
INNER JOIN Potkategorija ON IDPotkategorija = PotkategorijaID
GROUP BY Potkategorija.Naziv, Boja
ORDER BY Amount DESC

SELECT Kategorija.Naziv, COUNT(KategorijaID)
FROM Kategorija
INNER JOIN Potkategorija ON KategorijaID = IDKategorija
GROUP BY Kategorija.Naziv

SELECT Kategorija.Naziv, COUNT(*)
FROM Kategorija
INNER JOIN Potkategorija ON KategorijaID = IDKategorija
INNER JOIN Proizvod ON PotkategorijaID = IDPotkategorija
GROUP BY Kategorija.Naziv

SELECT CijenaBezPDV, COUNT(*)
FROM Proizvod
GROUP BY CijenaBezPDV

SELECT YEAR(DatumIzdavanja), COUNT(*)
FROM Racun
GROUP BY YEAR(DatumIzdavanja)

SELECT IDRacun, SUM(UkupnaCijena)
FROM Racun
INNER JOIN Stavka ON RacunID = IDRacun
WHERE KupacID = 377
GROUP BY IDRacun