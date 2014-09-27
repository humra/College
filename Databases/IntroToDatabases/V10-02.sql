USE LosFilm2

SELECT Film.Naziv, Posudba.DatumPosudbe, Clan.ImePrezime
FROM Film
RIGHT OUTER JOIN Posudba ON Posudba.FilmID = Film.ID
INNER JOIN Clan ON Posudba.ClanID = Clan.ID

SELECT Clan.ImePrezime, Mjesto.Naziv
FROM Clan
RIGHT OUTER JOIN Mjesto ON Mjesto.ID = Clan.MjestoID

SELECT DISTINCT Mjesto.Naziv AS Mjesto,
Film.Naziv AS Film,
Zanr.Naziv AS Zanr
FROM Mjesto
INNER JOIN Clan ON Clan.MjestoID = MjestoID
INNER JOIN Posudba ON Posudba.ClanID = Clan.ID
LEFT OUTER JOIN Film ON Film.ID = Posudba.FilmID
INNER JOIN Zanr ON Zanr.ID = Film.ZanrID