USE LosFilm3

SELECT Film.Naziv, Medij.Naziv AS Medij
FROM Film
INNER JOIN Medij ON Film.MedijID = Medij.ID

SELECT Film.Naziv, Medij.Naziv AS MEDIJ,
Zanr.Naziv AS Zanr
FROM Film
INNER JOIN Medij ON Film.MedijID = Medij.ID
INNER JOIN Zanr ON Film.ZanrID = Zanr.ID

SELECT DISTINCT Clan.ImePrezime, Film.Naziv
FROM Film
INNER JOIN Posudba ON Posudba.FilmID = Film.ID
INNER JOIN Clan ON Posudba.ClanID = Clan.ID

SELECT DISTINCT Film.Naziv, Clan.ImePrezime
FROM Film
INNER JOIN Posudba ON Posudba.FilmID = Film.ID
INNER JOIN Clan ON Posudba.ClanID = Clan.ID

SELECT ImePrezime,
Ulica + ' ' + KucniBroj + ' ' + Mjesto.Naziv AS Adresa
FROM Clan
INNER JOIN Mjesto ON Mjesto.ID = Clan.MjestoID
INNER JOIN Zakasnina ON Clan.ID = Zakasnina.ClanID
WHERE Zakasnina.NaplacenaZakasnina IS NOT NULL

SELECT Film.Naziv, Mjesto.Naziv
FROM Film
INNER JOIN Posudba ON Film.ID = Posudba.ClanID
INNER JOIN Clan ON Clan.ID = Posudba.ClanID
INNER JOIN Mjesto ON Clan.MjestoID = Mjesto.ID

SELECT DISTINCT Clan.ImePrezime, Zanr.Naziv
FROM Clan
INNER JOIN Posudba ON Clan.ID = Posudba.ClanID
INNER JOIN Film ON Film.ID = Posudba.FilmID
INNER JOIN Zanr ON Zanr.ID = Film.ID

SELECT Clan.ImePrezime,
Clan.Ulica + ' ' + Clan.KucniBroj + ' ' + Mjesto.Naziv,
Film.Naziv
FROM Clan
INNER JOIN Zakasnina ON Zakasnina.ClanID = Clan.ID
INNER JOIN Film ON Film.ID = Zakasnina.FilmID
INNER JOIN Mjesto ON Clan.MjestoID = Mjesto.ID

SELECT DISTINCT Film.Naziv, Mjesto.Naziv
FROM Film
INNER JOIN Posudba ON Film.ID = Posudba.FilmID
INNER JOIN Clan ON Posudba.ClanID = Clan.ID
INNER JOIN Mjesto ON Clan.MjestoID = Mjesto.ID