CREATE TABLE Film
(
	IDFilm int CONSTRAINT PK_IDFilm PRIMARY KEY IDENTITY,
	Naziv nvarchar(50) NOT NULL,
	GodinaProizvodnje int,
	TrajanjeMinuta int,
	KratkiOpis nvarchar(250)
)
GO

INSERT INTO Film (Naziv, GodinaProizvodnje, TrajanjeMinuta)
VALUES ('Matrix', 1998, 120),
('Lord of the Rings', 2001, 175),
('Guardians of galaxy', 2014, 125)
GO

CREATE VIEW Filmovi AS
SELECT * FROM Film
GO

SELECT * FROM Filmovi
GO

ALTER TABLE Film
DROP COLUMN TrajanjeMinuta
GO

SELECT * FROM Filmovi
GO

ALTER VIEW Filmovi WITH SCHEMABINDING AS
SELECT IDFilm, Naziv, GodinaProizvodnje, KratkiOpis
FROM dbo.Film
GO

SELECT * FROM Filmovi
GO

ALTER TABLE Film
DROP COLUMN GodinaProizvodnje
GO

DROP VIEW Filmovi
GO
DROP TABLE Film
GO