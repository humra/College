CREATE VIEW Kreditne AS
SELECT *
FROM KreditnaKartica
WHERE KreditnaKartica.Tip = 'Visa' OR
KreditnaKartica.Tip = 'MasterCard'
GO

INSERT INTO Kreditne (Tip, IstekGodina, Broj, IstekMjesec)
VALUES ('American Express', 2015, '1254656', 7)
GO

ALTER VIEW Kreditne AS 
SELECT *
FROM KreditnaKartica
WHERE KreditnaKartica.Tip = 'Visa' OR
KreditnaKartica.Tip = 'MasterCard'
WITH CHECK OPTION
GO

INSERT INTO Kreditne (Tip, IstekGodina, Broj, IstekMjesec)
VALUES ('MasterCard', 2016, '55885588', 2)
GO

ALTER VIEW Kreditne AS 
SELECT *
FROM KreditnaKartica
WHERE KreditnaKartica.Tip = 'Visa' OR
KreditnaKartica.Tip = 'MasterCard'
GO

DROP VIEW Kreditne
GO