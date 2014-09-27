USE LosFilm3

SELECT Film.Naziv AS Naziv,
Film.Trajanje AS Trajanje,
Zanr.Naziv AS Zanr
FROM Film
INNER JOIN Zanr ON Zanr.ID = Film.ZanrID

SELECT ImePrezime, 
Ulica + ' ' + KucniBroj AS Adresa,
Mjesto.PostanskiBroj AS PB,
Mjesto.Naselje AS Naselje
FROM Clan
INNER JOIN Mjesto ON Clan.MjestoID = Mjesto.ID

SELECT Film.Naziv, Film.Trajanje,
Zanr.Naziv AS Zanr
FROM Film
INNER JOIN Medij ON Medij.ID = Film.MedijID
INNER JOIN Zanr ON Film.ZanrID = Zanr.ID
WHERE Medij.Naziv = 'DVD'