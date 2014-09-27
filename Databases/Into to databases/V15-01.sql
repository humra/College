USE AdventureWorksOBP

SELECT AVG(CijenaBezPDV) AS AverageProduct, Proizvod.Naziv,
	(
	SELECT AVG(CijenaBezPDV)
	FROM Proizvod
	) AS AverageAll,  
	(
	SELECT AVG(CijenaBezPDV)
	FROM Proizvod
	) - AVG(CijenaBezPDV) AS Diff
FROM Proizvod
GROUP BY Proizvod.Naziv
HAVING AVG(CijenaBezPDV) > 0

SELECT TOP 5 Ime, Prezime, COUNT(KomercijalistID) AS Sold
FROM Komercijalist
INNER JOIN Racun ON KomercijalistID = IDKomercijalist
GROUP BY Ime, Prezime
ORDER BY Sold DESC

SELECT TOP 5 Ime, Prezime, SUM(UkupnaCijena) AS Sold
FROM Komercijalist
INNER JOIN Racun ON KomercijalistID = IDKomercijalist
INNER JOIN Stavka ON RacunID = IDRacun
GROUP BY Ime, Prezime
ORDER BY Sold DESC

SELECT Boja,
	(
	SELECT COUNT(Boja)
	) AS Amount
FROM Proizvod
WHERE Boja IS NOT NULL
GROUP BY Boja

SELECT Ime, Prezime, COUNT(KupacID) AS Bills
FROM Kupac
INNER JOIN Grad ON GradID = IDGrad
INNER JOIN Racun ON IDKupac = KupacID
WHERE Grad.Naziv = 'Frankfurt'
GROUP BY Ime, Prezime
ORDER BY Bills DESC