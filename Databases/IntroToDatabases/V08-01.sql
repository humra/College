USE LosFilm2

INSERT Mjesto (PostanskiBroj, Naziv, Naselje, Zupanija)
VALUES (21220, 'Trogir', 'Trogir', 'SPLITSKO-DALMATINSKA');

INSERT Clan (ID, ImePrezime, Ulica, KucniBroj, MjestoID, Telefon)
VALUES (8, 'Ivan Skrlecz', 'Humrina ulica', 42, 8, '084-123456'),
(9, 'Petar Berislaviæ', 'Leonova ulica', 69, 451, '084-654321');

INSERT Medij (ID, Naziv)
VALUES (5, 'Blue-ray');

INSERT Film (ID, MedijID, Naziv, Trajanje, Reziser, GlavniGlumci, SporedniGlumci, ZanrID, KratkiOpis)
VALUES (10, 5, 'Blade Runner', 122, NULL, 'Harrison Ford', NULL, 1, 'opis'),
(11, 5, 'Prohujalo s vihorom', 124, NULL, NULL, NULL,6 , 'opis');

UPDATE Film
SET GlavniGlumci = + 'Monica Belucci',
SporedniGlumci = + 'Valerie Berry',
ZanrID = 3,
KratkiOpis = 'opis'
WHERE Naziv = 'The Matrix Reloaded';

INSERT Posudba (FilmID, ClanID, DatumPosudbe, DatumVracanja)
VALUES (1, 8, '19140416', '19140419'),
(4, 8, '19140419', '19140421'),
(11, 9, '17990520', '17990530');

INSERT Zakasnina (ClanID, FilmID, Datum, NaplacenaZakasnina)
VALUES (8, 1, '19140419', 15.00),
(9, 11, '17990530', 16.00);

SELECT *
FROM Posudba
WHERE ClanID = 1 AND DatumVracanja IS NULL

UPDATE Posudba
SET DatumVracanja = '20140521'
WHERE ClanID = 1 AND DatumVracanja IS NULL

INSERT Zakasnina (FilmID, ClanID, Datum, NaplacenaZakasnina)
VALUES (1, 1, '20140315', 134),
(2, 1, '20140315', 134),
(3, 1, '20140320', 124),
(4, 1, '20140320', 124),
(5, 1, '20140322', 120);

DELETE FROM Posudba
WHERE ClanID = 2