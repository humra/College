CREATE VIEW KupciKontakt AS
SELECT Ime, Prezime, Email, Grad.Naziv AS Grad, Drzava.Naziv AS Drzava
FROM Kupac
INNER JOIN Grad ON Grad.IDGrad = Kupac.GradID
INNER JOIN Drzava ON Drzava.IDDrzava = Grad.DrzavaID
GO

CREATE VIEW KupciPoDrzavi AS
SELECT Drzava.Naziv AS Drzava, COUNT(*) AS Kupaca
FROM Drzava
INNER JOIN Grad ON Drzava.IDDrzava = Grad.DrzavaID
INNER JOIN Kupac ON Kupac.GradID = Grad.IDGrad
GROUP BY Drzava.Naziv
GO

CREATE VIEW PunoKupaca AS
SELECT Proizvod.Naziv, COUNT(*) AS Prodano
FROM Proizvod
INNER JOIN Stavka ON Stavka.ProizvodID = Proizvod.IDProizvod
GROUP BY Proizvod.Naziv
HAVING COUNT(*) > 300
GO

CREATE VIEW TopProizvod AS
SELECT TOP 5 Naziv, SUM(Stavka.UkupnaCijena) AS Zarada
FROM Proizvod
INNER JOIN Stavka ON Stavka.ProizvodID = Proizvod.IDProizvod
GROUP BY Naziv
ORDER BY 2 DESC
GO

DROP VIEW KupciKontakt
GO
DROP VIEW KupciPoDrzavi
GO
DROP VIEW PunoKupaca
GO
DROP VIEW TopProizvod
GO