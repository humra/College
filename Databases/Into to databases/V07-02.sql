USE Mikroprodaja

INSERT Zaposlenik (OIB, Ime, Prezime, NadredjeniOIB, ProdajnoMjestoID, VrstaZaposlenikaID)
VALUES (1234567899876, 'Pero', 'Periæ', NULL, 2, 1),
(9876543210000, 'Ivan', 'Ivèiæ', NULL, 1, 1);

INSERT ProdajnoMjesto (Naziv, Adresa)
VALUES ('Èetvrti duæan', 'Zagrebaèka 42');

SELECT Ime, Prezime
FROM Zaposlenik
ORDER BY Ime ASC

SELECT Naziv
FROM Proizvod
ORDER BY Cijena DESC

SELECT Naziv
FROM Proizvod
WHERE Cijena <= 10

SELECT DISTINCT Cijena
FROM Proizvod