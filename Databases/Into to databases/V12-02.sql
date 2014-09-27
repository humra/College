USE LosFilm2

SELECT MedijID, COUNT(MedijID) AS Amount
FROM Film
GROUP BY MedijID

SELECT AVG(Trajanje) AS AVGLength, Zanr.Naziv
FROM Film
INNER JOIN Zanr ON Zanr.ID = ZanrID
WHERE Zanr.Naziv = 'SF' OR Zanr.Naziv = 'Drama'
GROUP BY Zanr.Naziv

SELECT COUNT(*) AS Rented, Zanr.Naziv
FROM Posudba
INNER JOIN Film ON FilmID = Film.ID
INNER JOIN Zanr ON Zanr.ID = ZanrID
WHERE MONTH(DatumPosudbe) = 3
GROUP BY Zanr.Naziv