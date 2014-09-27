CREATE VIEW SviKupci AS
SELECT * 
FROM Kupac
GO

CREATE VIEW KupciLA AS
SELECT *
FROM Kupac
WHERE Ime LIKE 'L%' AND
Prezime LIKE '%a'
GO

CREATE VIEW GradOsobeGROUP AS
SELECT Grad.Naziv, (SELECT COUNT(*) FROM Kupac WHERE Kupac.GradID = Grad.IDGrad) AS Ljudi
FROM Grad
ORDER BY 2 DESC
GO

CREATE VIEW GradOsobeQUERY AS
SELECT TOP 100 PERCENT Grad.Naziv, COUNT(*) AS Populacija
FROM Grad
INNER JOIN Kupac ON Kupac.GradID = Grad.IDGrad
GROUP BY Grad.Naziv
ORDER BY 2 DESC
GO

CREATE VIEW Osobe AS
SELECT Ime, Prezime, Grad.Naziv AS Grad, Drzava.Naziv AS Drzava
FROM Kupac
INNER JOIN Grad ON Grad.IDGrad = Kupac.GradID
INNER JOIN Drzava ON Drzava.IDDrzava = Grad.DrzavaID
GO 

CREATE VIEW Kupci AS
SELECT IDKupac, Ime, Prezime
FROM Kupac
GO

DROP VIEW Kupci
GO