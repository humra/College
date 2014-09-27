USE LosFilm2

SELECT AVG(Trajanje)
FROM Film

SELECT AVG(Trajanje)
FROM Film
INNER JOIN Zanr ON Zanr.ID = Zanrid
WHERE Zanr.Naziv = 'SF'

SELECT DISTINCT MONTH(DatumPosudbe)
FROM Posudba

SELECT COUNT(FilmID)
FROM Posudba
WHERE MONTH(DatumPosudbe) = 4

USE AdventureWorksOBP

SELECT COUNT(*)
FROM Proizvod

SELECT COUNT(Boja)
FROM Proizvod
WHERE Boja IS NOT NULL

SELECT MAX(CijenaBezPDV)
FROM Proizvod

SELECT AVG(CijenaBezPDV)
FROM Proizvod
WHERE PotkategorijaID = 16

SELECT MAX(DatumIzdavanja) AS Newest, MIN(DatumIzdavanja) AS Oldest
FROM Racun
WHERE KupacID = 131