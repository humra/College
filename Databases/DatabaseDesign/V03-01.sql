CREATE VIEW Kategorije AS
SELECT *
FROM Kategorija
GO

SELECT *,
Potkategorija.Naziv AS PotkategorijaNaziv,
Proizvod.Naziv AS ProizvodNaziv
FROM Kategorije
RIGHT JOIN Potkategorija ON Potkategorija.KategorijaID = Kategorije.IDKategorija
RIGHT JOIN Proizvod ON Proizvod.PotkategorijaID = Potkategorija.IDPotkategorija
GO

INSERT INTO Kategorije (Naziv)
VALUES ('Alarmi')
GO

UPDATE Kategorije 
SET Naziv = 'Aktivna zastita'
WHERE Naziv = 'Alarmi'
GO

DELETE FROM Kategorije
WHERE Naziv = 'Aktivna zastita'
GO

DROP VIEW Kategorije
GO