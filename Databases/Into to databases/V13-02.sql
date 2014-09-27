USE AdventureWorksOBP

SELECT Ime, Prezime,
	(
	SELECT Grad.Naziv
	FROM Grad
	WHERE IDGrad = GradID
	) AS Grad
FROM Kupac

SELECT Ime, Prezime, Grad.Naziv
FROM Kupac
INNER JOIN Grad ON GradID = IDGrad
WHERE Grad.Naziv = 'Sarajevo'

SELECT DatumIzdavanja, MAX(UkupnaCijena) AS Max, MIN(UkupnaCijena) AS Min, IDStavka
FROM Racun
INNER JOIN Stavka ON RacunID = IDRacun
GROUP BY DatumIzdavanja, IDStavka