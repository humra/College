USE LosFilm2

SELECT MIN(Trajanje) AS Shortest,
MAX(Trajanje) AS Longest
FROM Film

SELECT AVG(Trajanje) AS Average
FROM Film

SELECT AVG(Trajanje) AS Average
FROM Film
INNER JOIN Zanr ON Zanr.ID = ZanrID
WHERE Zanr.Naziv = 'SF'

SELECT DISTINCT MONTH(DatumPosudbe)
FROM Posudba

SELECT COUNT(FilmID)
FROM Posudba
WHERE MONTH(DatumPosudbe) = 4

SELECT FilmID
FROM Posudba
WHERE DATEDIFF(day, DatumPosudbe, DatumVracanja) > 2

SELECT Naziv, ISNULL(CAST(DatumVracanja AS varchar), 'NIJE VRACEN')
FROM Film
INNER JOIN Posudba ON FilmID = Film.ID