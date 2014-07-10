USE LosFilm2

SELECT Mjesto.Naziv, COUNT(*)
FROM Mjesto
INNER JOIN Clan ON MjestoID = Clan.ID
INNER JOIN Posudba ON Clan.ID = ClanID
GROUP BY Mjesto.Naziv

SELECT Mjesto.Naziv, COUNT(*)
FROM Mjesto
INNER JOIN Clan ON MjestoID = Clan.ID
INNER JOIN Posudba ON Clan.ID = ClanID
GROUP BY Mjesto.Naziv
HAVING COUNT(*) > 1

SELECT Zanr.Naziv, MAX(Trajanje)
FROM Zanr
INNER JOIN Film ON Film.ZanrID = Zanr.ID
GROUP BY Zanr.Naziv
HAVING MAX(Trajanje) > 138

SELECT Zanr.Naziv, AVG(Trajanje)
FROM Zanr
INNER JOIN Film ON Film.ZanrID = Zanr.ID
GROUP BY Zanr.Naziv
HAVING AVG(Film.Trajanje) * 1.02 > MIN(Film.Trajanje)