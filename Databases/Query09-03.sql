USE AdventureWorksOBP

--SELECT DISTINCT Boja,
--COUNT(*) AS Kolicina
--FROM Proizvod
--GROUP BY Boja

--SELECT DISTINCT Boja,
--COUNT(*) AS Kolicina
--FROM Proizvod
--GROUP BY Boja
--ORDER BY Kolicina DESC;

--SELECT DISTINCT Boja,
--COUNT(*) AS Kolicina
--FROM Proizvod
--WHERE Boja IS NOT NULL
--GROUP BY Boja
--ORDER BY Kolicina DESC;

--SELECT DISTINCT PotkategorijaID,
--COUNT(Boja) AS Colour, Boja
--FROM Proizvod
--WHERE PotkategorijaID IS NOT NULL AND
--Boja IS NOT NULL
--GROUP BY Boja, PotkategorijaID;

--SELECT DISTINCT TOP 10 PotkategorijaID,
--COUNT(Boja) AS Colour, Boja
--FROM Proizvod
--WHERE PotkategorijaID IS NOT NULL AND
--Boja IS NOT NULL
--GROUP BY Boja, PotkategorijaID;

--SELECT DISTINCT TOP 10 Potkategorija.Naziv,
--COUNT(Boja) AS Colour, Boja
--FROM Proizvod
--INNER JOIN Potkategorija ON PotkategorijaID = IDPotkategorija
--WHERE PotkategorijaID IS NOT NULL AND
--Boja IS NOT NULL
--GROUP BY Boja, Potkategorija.Naziv;

--SELECT Kategorija.Naziv,
--COUNT (KategorijaID) AS Members
--FROM Potkategorija
--INNER JOIN Kategorija ON KategorijaID = IDKategorija
--GROUP BY Kategorija.Naziv;

--SELECT DISTINCT Kategorija.Naziv,
--COUNT(PotkategorijaID) AS Number
--FROM Kategorija
--INNER JOIN Potkategorija ON IDKategorija = KategorijaID
--INNER JOIN Proizvod ON PotkategorijaID = IDPotkategorija
--GROUP BY PotkategorijaID, Kategorija.Naziv;

--SELECT DISTINCT CijenaBezPDV,
--COUNT(Naziv)
--FROM Proizvod
--GROUP BY CijenaBezPDV;

--SELECT DISTINCT YEAR(DatumIzdavanja),
--COUNT(DatumIzdavanja) AS NumberOfIssued
--FROM Racun
--GROUP BY YEAR(DatumIzdavanja);

--SELECT DISTINCT BrojRacuna,
--SUM(UkupnaCijena) AS Total
--FROM Racun
--INNER JOIN Stavka ON RacunID = IDRacun
--WHERE KupacID = 377
--GROUP BY UkupnaCijena, BrojRacuna;

