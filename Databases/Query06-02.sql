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
WHERE Zupanija = 'ZAGREBA�KA' OR
Zupanija = 'ZADARSKA' OR
Zupanija = 'ME�IMURSKA'

SELECT Naziv
FROM Mjesto
WHERE Zupanija != 'ISTARSKA' OR
Zupanija != 'KARLOVA�KA'

UPDATE Clan
SET ImePrezime = 'Pero Peri� jr.'
WHERE ImePrezime = 'Pero Peri�'

SELECT ImePrezime, Ulica + ' ' + KucniBroj AS Adresa
FROM Clan
WHERE ImePrezime LIKE 'Pero Peri�%' OR
ImePrezime = 'Ana Mili�' OR
ImePrezime = 'Sanja Tarak'