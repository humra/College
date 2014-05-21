USE AdventureWorksOBP

SELECT Naziv
FROM Proizvod

SELECT DISTINCT Boja
FROM Proizvod

SELECT Naziv, MinimalnaKolicinaNaSkladistu
FROM Proizvod
ORDER BY MinimalnaKolicinaNaSkladistu DESC

SELECT TOP 15 Naziv
FROM Proizvod
ORDER BY MinimalnaKolicinaNaSkladistu ASC

SELECT Naziv
FROM Proizvod
WHERE MinimalnaKolicinaNaSkladistu <= 100

SELECT Naziv
FROM Proizvod
WHERE MinimalnaKolicinaNaSkladistu BETWEEN 300 AND 400
ORDER BY Boja ASC

SELECT Ime, Prezime
FROM Komercijalist
WHERE StalniZaposlenik = 1

SELECT DISTINCT Tip, IDKreditnaKartica
FROM KreditnaKartica
ORDER BY Tip ASC

SELECT Ime, Prezime
FROM Kupac
WHERE Email IS NOT NULL

SELECT DISTINCT Naziv, DrzavaID
FROM Grad
ORDER BY DrzavaID, Naziv ASC

SELECT DISTINCT Naziv, DrzavaID
FROM Grad
ORDER BY Naziv, DrzavaID ASC

SELECT DISTINCT Naziv
FROM Grad
WHERE DrzavaID = 1
ORDER BY Naziv DESC