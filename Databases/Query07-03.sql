USE AdventureWorksOBP

SELECT DISTINCT Racun.DatumIzdavanja, Stavka.UkupnaCijena,
Kupac.Ime + ' ' + Kupac.Prezime AS Kupac
FROM Racun
INNER JOIN Stavka ON Stavka.RacunID = Racun.IDRacun
INNER JOIN Kupac ON Kupac.IDKupac = Racun.KupacID

SELECT DISTINCT Kupac.Ime + ' ' + Kupac.Prezime AS Kupac,
Proizvod.Naziv
FROM Kupac
INNER JOIN Racun ON Racun.KupacID = Kupac.IDKupac
INNER JOIN Stavka ON Racun.IDRacun = Stavka.RacunID
INNER JOIN Proizvod ON Stavka.ProizvodID = Proizvod.IDProizvod

SELECT DISTINcT Kupac.Ime + ' ' + Kupac.Prezime AS Kupac,
Kategorija.Naziv
FROM Kupac
INNER JOIN Racun ON Racun.KupacID = Kupac.IDKupac
INNER JOIN Stavka ON Racun.IDRacun = Stavka.RacunID
INNER JOIN Proizvod ON Stavka.ProizvodID = Proizvod.IDProizvod
INNER JOIN Potkategorija ON Potkategorija.KategorijaID = Proizvod.PotkategorijaID
INNER JOIN Kategorija ON Potkategorija.KategorijaID = Kategorija.IDKategorija

SELECT DISTINCT Proizvod.Naziv AS Proizvod,
Kategorija.Naziv AS Kategorija,
Potkategorija.Naziv AS Potkategorija
FROM Proizvod
INNER JOIN Potkategorija ON Proizvod.PotkategorijaID = Potkategorija.IDPotkategorija
INNER JOIN Kategorija ON Potkategorija.KategorijaID = Kategorija.IDKategorija