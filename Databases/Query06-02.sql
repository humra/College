USE LosFilm2

SELECT ImePrezime
FROM Clan
WHERE ImePrezime LIKE '%k %'

SELECT Naziv
FROM Mjesto
WHERE Naziv LIKE 'Ve%'

SELECT Naziv
FROM Film
WHERE Naziv LIKE '%Matrix%'

SELECT Naziv
FROM Mjesto
WHERE Naziv NOT LIKE '% %'

SELECT Naziv
FROM Mjesto
WHERE Zupanija = 'ZAGREBAÈKA' OR
Zupanija = 'ZADARSKA' OR
Zupanija = 'MEÐIMURSKA'

SELECT Naziv
FROM Mjesto
WHERE Zupanija != 'ISTARSKA' OR
Zupanija != 'KARLOVAÈKA'

UPDATE Clan
SET ImePrezime = 'Pero Periæ jr.'
WHERE ImePrezime = 'Pero Periæ'

SELECT ImePrezime, Ulica + ' ' + KucniBroj AS Adresa
FROM Clan
WHERE ImePrezime LIKE 'Pero Periæ%' OR
ImePrezime = 'Ana Miliæ' OR
ImePrezime = 'Sanja Tarak'