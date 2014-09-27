USE LosFilm2

SELECT ImePrezime
FROM Clan
INNER JOIN Posudba ON ClanID = Clan.ID
INNER JOIN Film ON Film.ID = FilmID
INNER JOIN Medij ON Medij.ID = MedijID
WHERE Medij.Naziv = 'DVD'

SELECT ImePrezime
FROM Clan
INNER JOIN Posudba ON  ClanID = Clan.ID
GROUP BY ImePrezime
HAVING COUNT(Posudba.ClanID) > AVG(FilmID)

SELECT Medij.Naziv, COUNT(MedijID)
FROM Medij
INNER JOIN Film ON MedijID = Medij.ID
INNER JOIN Posudba ON FilmID = Film.ID
GROUP BY Medij.Naziv