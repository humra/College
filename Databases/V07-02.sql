USE Mikroprodaja

INSERT Zaposlenik (OIB, Ime, Prezime, NadredjeniOIB, ProdajnoMjestoID, VrstaZaposlenikaID)
VALUES (1234567899876, 'Pero', 'Peri�', NULL, 2, 1),
(9876543210000, 'Ivan', 'Iv�i�', NULL, 1, 1);

INSERT ProdajnoMjesto (Naziv, Adresa)
VALUES ('�etvrti du�an', 'Zagreba�ka 42');

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