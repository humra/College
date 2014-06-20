USE Videoteka

INSERT Clan (IDClana, ImePrezime, Adresa, Telefon)
VALUES (2, 'Pero Periæ', 'Unska 16', '084-123456'),
(3, 'Ana Miliæ', 'Zagrebaèka 13', NULL),
(4, 'Sanja Tarak', 'Aniæeva 16', '085-654321');

INSERT Film (IDFilm, TipMedija, Naziv, Trajanje, Reziser, GlavniGlumac, SporedniGlumac, Zanar, KratkiOpis)
VALUES (1, 'DVD', 'Matrix', 136, 'Andy i Larry Wachowski', 'Keanu Reeves', 'Laurence Fishbourne', 'SF', 'opis'),
(2, 'DVD', 'Matrix Reloaded', 138, 'Andy i Larry Wachowski', 'Keanu Reeves', 'Helmut Bakatis', 'SF', 'opis'),
(3, 'DVD', 'Matrix Revolutions', 129, 'Andy i Larry Wachowski', 'Keanu Reeves', 'Monica Belucci', 'SF', 'opis');

INSERT Posudba (FilmID, ClanID, DatumPosudbe, DatumVracanja)
VALUES (1, 1, '20120416', '20120417'),
(1, 1, '20120415', '20120417'),
(1, 2, '20120410', NULL);

DELETE FROM Clan
WHERE ImePrezime = 'Sanja Tarak';

UPDATE Film
SET Trajanje = 150
WHERE Naziv = 'Matrix';

INSERT Film (IDFilm, TipMedija, Naziv, Trajanje, Reziser, GlavniGlumac, SporedniGlumac, Zanar, KratkiOpis)
VALUES (4, 'CD', 'The Exorcist', 118, NULL, NULL, NULL, 'Horor', 'opis');

INSERT Clan (IDClana, ImePrezime, Adresa, Telefon)
VALUES (5, 'Ana Aniæ', 'Zagrebaèka 20', '084-321654');

UPDATE Film
SET TipMedija = 'Blue-Ray'
WHERE Naziv = 'Matrix';

UPDATE Clan
SET Adresa = 'Unska 26', Telefon = '084-123123'
WHERE ImePrezime = 'Pero Periæ'

DELETE FROM Film
WHERE Naziv = 'Matrix Reloaded'

DELETE FROM Posudba
WHERE ClanID = 2
DELETE FROM Clan
WHERE ImePrezime = 'Ana Miliæ'

SELECT ImePrezime
FROM Clan

SELECT Naziv
FROM Film
WHERE TipMedija = 'DVD'

SELECT Naziv
FROM Film
WHERE Trajanje >= 135

SELECT ImePrezime
FROM Clan
ORDER BY Adresa ASC

SELECT ImePrezime
FROM Clan
WHERE Telefon IS NOT NULL

SELECT Naziv
FROM Film
WHERE Zanar = 'SF'