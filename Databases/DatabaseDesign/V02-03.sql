CREATE VIEW Zagrepcani AS
SELECT Ime, Prezime, Email
FROM Kupac
INNER JOIN Grad ON Kupac.GradID = Grad.IDGrad
WHERE Grad.Naziv = 'Zagreb'
GO

CREATE VIEW ISplicani AS
SELECT Ime, Prezime, Email
FROM Kupac
INNER JOIN Grad ON Kupac.GradID = Grad.IDGrad
WHERE Grad.Naziv = 'Zagreb' OR
Grad.Naziv = 'Split'
GO

CREATE VIEW Prebroji AS
SELECT TOP 1 (SELECT COUNT(*)
FROM Kupac
INNER JOIN Grad ON Grad.IDGrad = Kupac.GradID
WHERE Grad.Naziv = 'Zagreb') AS Zagreb,
(SELECT COUNT(*)
FROM Kupac
INNER JOIN Grad ON Grad.IDGrad = Kupac.GradID
WHERE Grad.Naziv = 'Split') AS Split
FROM Kupac
GO

DROP VIEW Zagrepcani
GO
DROP VIEW ISplicani
GO
DROP VIEW Prebroji
GO