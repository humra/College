CREATE VIEW Gradovi AS
SELECT  IDGrad, DrzavaID, Grad.Naziv AS Grad,
IDDrzava, Drzava.Naziv AS Drzava,
Kupac.*
FROM Grad
FULL OUTER JOIN Drzava ON Drzava.IDDrzava = Grad.DrzavaID
FULL OUTER JOIN Kupac ON Kupac.GradID = Grad.IDGrad
GO

INSERT INTO Gradovi (Grad)
VALUES ('Velika Gorica')
GO

INSERT INTO Gradovi (Drzava)
VALUES ('Belgija')
GO

DROP VIEW Gradovi
GO