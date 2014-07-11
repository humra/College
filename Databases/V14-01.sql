USE LosFilm2

SELECT Mjesto.Naziv, COUNT(Clan.ID) AS BrojPosudba
FROM Mjesto
INNER JOIN Clan ON MjestoID = Mjesto.ID
INNER JOIN Posudba ON Clan.ID = ClanID
GROUP BY Mjesto.Naziv

SELECT ImePrezime, COUNT(ClanID) AS BrojPosudba
FROM Clan
INNER JOIN Posudba ON ClanID = Clan.ID
GROUP BY ImePrezime

SELECT Medij.Naziv, COUNT(MedijID) AS Broj
FROM Medij
INNER JOIN Film ON MedijID = Medij.ID
GROUP BY Medij.Naziv

SELECT Zanr.Naziv, COUNT(FilmID) AS Broj
FROM Zanr
INNER JOIN Film ON Zanr.ID = ZanrID
INNER JOIN Posudba ON Film.ID = FilmID
GROUP BY Zanr.Naziv

SELECT Zanr.Naziv, COUNT(ClanID) AS Broj
FROM Zanr
INNER JOIN Film ON Zanr.ID = ZanrID
INNER JOIN Posudba ON FilmID = Film.ID
INNER JOIN Clan ON ClanID = Clan.ID
GROUP BY Zanr.Naziv

SELECT Zanr.Naziv, COUNT(FilmID) AS Broj
FROM Zanr
INNER JOIN Film ON ZanrID = Zanr.ID
INNER JOIN Posudba ON FilmID = Film.ID
GROUP BY Zanr.Naziv
ORDER BY Broj DESC

SELECT Mjesto.Naziv, Zanr.Naziv, AVG(DATEDIFF(day, DatumPosudbe, DatumVracanja)) AS Average
FROM Mjesto
INNER JOIN Clan ON Mjesto.ID = Clan.MjestoID
INNER JOIN Posudba ON ClanID = Clan.ID
INNER JOIN Film ON FilmID = Film.ID
INNER JOIN Zanr ON ZanrID = Zanr.ID
GROUP BY Mjesto.Naziv, Zanr.Naziv