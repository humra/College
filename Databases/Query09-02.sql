USE AdventureWorksOBP

SELECT COUNT(*) AS Total
FROM Proizvod;

SELECT COUNT(Boja) AS ColorDefined
FROM Proizvod;

SELECT MAX(CijenaBezPDV) AS MostExpensive
FROM Proizvod;

SELECT AVG(CijenaBezPDV) AS Average
FROM Proizvod
WHERE PotkategorijaID = 16;

SELECT MAX(CAST(DatumIzdavanja AS int)) AS MostRecent,
MIN(CAST(DatumIzdavanja AS int))  AS LeastRecent
FROM Racun
WHERE KupacID = 131;