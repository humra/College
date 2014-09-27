USE LosFilm2

SELECT Film.Naziv
FROM Film
WHERE Film.ID IN
	(
	SELECT FilmID
	FROM Posudba
	)

SELECT ImePrezime
FROM Clan
WHERE Clan.ID IN
	(
	SELECT ClanID
	FROM Posudba
	)

SELECT ImePrezime
FROM Clan
WHERE Clan.id IN
	(
	SELECT ClanID
	FROM Posudba
	INNER JOIN Film ON Film.ID = FilmID
	INNER JOIN Medij ON Medij.ID = MedijID
	WHERE Medij.Naziv = 'DVD'
	)

SELECT Film.Naziv
FROM Film
WHERE Film.ID IN
	(
	SELECT FilmID
	FROM Posudba
	WHERE ClanID > 2
	)