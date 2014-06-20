USE AdventureWorksOBP

SELECT DISTINCT Proizvod.Naziv
FROM Proizvod
INNER JOIN Stavka ON Proizvod.IDProizvod = Stavka.ProizvodID
WHERE Kolicina >= 35

SELECT DISTINCT Kupac.Ime + ' ' + Kupac.Prezime AS Kupac,
Grad.Naziv AS Grad,
Drzava.Naziv AS Drzava
FROM Kupac
INNER JOIN Racun ON Racun.KupacID = KupacID
INNER JOIN Grad ON Grad.IDGrad = Kupac.GradID
INNER JOIN Drzava ON Drzava.IDDrzava = Grad.DrzavaID

SELECT Racun.IDRacun, Racun.BrojRacuna,
Kupac.Ime + ' ' + Kupac.Prezime + ', ' + Grad.Naziv AS Kupac,
Komercijalist.Ime + ' ' + Komercijalist.Prezime AS Komercijalist,
KreditnaKartica.IstekGodina, KreditnaKartica.IstekMjesec
FROM Racun
INNER JOIN Kupac ON Kupac.IDKupac = Racun.KupacID
INNER JOIN Grad ON Kupac.GradID = Grad.IDGrad
INNER JOIN Komercijalist ON Komercijalist.IDKomercijalist = Racun.KomercijalistID
INNER JOIN KreditnaKartica ON KreditnaKartica.IDKreditnaKartica = Racun.KreditnaKarticaID
WHERE Racun.DatumIzdavanja = '20020801' AND
KreditnaKartica.Tip = 'American Express'
ORDER BY Kupac.Prezime ASC

SELECT DISTINCT Drzava.Naziv, KreditnaKartica.Tip
FROM Drzava
INNER JOIN Grad ON Drzava.IDDrzava = Grad.DrzavaID
INNER JOIN Kupac ON Kupac.GradID = Grad.IDGrad
INNER JOIN Racun ON Racun.KupacID = Kupac.IDKupac
INNER JOIN KreditnaKartica ON KreditnaKartica.IDKreditnaKartica = Racun.KreditnaKarticaID

SELECT DISTINCT Komercijalist.Ime + ' ' + Komercijalist.Prezime AS Komercijalist,
Kategorija.Naziv
FROM Komercijalist
INNER JOIN Racun ON Racun.KomercijalistID = Komercijalist.IDKomercijalist
INNER JOIN Stavka ON Racun.IDRacun = Stavka.RacunID
INNER JOIN Proizvod ON Proizvod.IDProizvod = Stavka.ProizvodID
INNER JOIN Potkategorija ON Proizvod.PotkategorijaID = Potkategorija.IDPotkategorija
INNER JOIN Kategorija ON Potkategorija.KategorijaID = Kategorija.IDKategorija

SELECT DISTINCT Kupac.Ime + ' ' + Kupac.Prezime AS Kupac,
Potkategorija.Naziv
FROM Kupac
INNER JOIN Racun ON Racun.KupacID = KupacID
INNER JOIN Stavka ON Racun.IDRacun = Stavka.RacunID
INNER JOIN Proizvod ON Proizvod.IDProizvod = Stavka.ProizvodID
INNER JOIN Potkategorija ON Potkategorija.IDPotkategorija = Proizvod.PotkategorijaID

SELECT DISTINCT Kategorija.Naziv, KreditnaKartica.Tip
FROM KreditnaKartica
INNER JOIN Racun ON Racun.KreditnaKarticaID = KreditnaKartica.IDKreditnaKartica
INNER JOIN Stavka ON Racun.IDRacun = Stavka.RacunID
INNER JOIN Proizvod ON Stavka.ProizvodID = Proizvod.IDProizvod
INNER JOIN Potkategorija ON Proizvod.PotkategorijaID = Potkategorija.IDPotkategorija
INNER JOIN Kategorija ON Potkategorija.KategorijaID = Kategorija.IDKategorija