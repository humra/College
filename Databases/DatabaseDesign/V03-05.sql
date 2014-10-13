CREATE VIEW Najprodavaniji AS
SELECT TOP 10 Proizvod.Naziv, Proizvod.IDProizvod, SUM(Kolicina) AS Prodano
FROM Proizvod
INNER JOIN Stavka ON Stavka.ProizvodID = Proizvod.IDProizvod
GROUP BY Naziv, IDProizvod
ORDER BY 3 DESC
GO

sp_helptext Najprodavaniji
GO

ALTER VIEW Najprodavaniji WITH ENCRYPTION AS
SELECT TOP 10 Proizvod.Naziv, Proizvod.IDProizvod, SUM(Kolicina) AS Prodano
FROM Proizvod
INNER JOIN Stavka ON Stavka.ProizvodID = Proizvod.IDProizvod
GROUP BY Naziv, IDProizvod
ORDER BY 3 DESC
GO

sp_helptext Najprodavaniji
GO

ALTER VIEW Najprodavaniji WITH ENCRYPTION, SCHEMABINDING AS
SELECT TOP 10 Proizvod.Naziv, Proizvod.IDProizvod, SUM(Kolicina) AS Prodano
FROM dbo.Proizvod
INNER JOIN dbo.Stavka ON Stavka.ProizvodID = Proizvod.IDProizvod
GROUP BY Naziv, IDProizvod
ORDER BY 3 DESC
GO

ALTER VIEW Najprodavaniji WITH ENCRYPTION, SCHEMABINDING AS
SELECT TOP 10 Proizvod.Naziv, Proizvod.IDProizvod, SUM(Kolicina) AS Prodano
FROM dbo.Proizvod
INNER JOIN dbo.Stavka ON Stavka.ProizvodID = Proizvod.IDProizvod
GROUP BY Naziv, IDProizvod
ORDER BY 3 DESC
WITH CHECK OPTION
GO

DROP VIEW Najprodavaniji
GO