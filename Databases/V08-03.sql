USE AdventureWorksOBP

SELECT Ime, Prezime
FROM Kupac
WHERE Ime NOT LIKE '%a'

UPDATE Kupac
SET Prezime = 'Vargas treæi'
WHERE Prezime = 'Vargas' AND 
Ime = 'Gary'

SELECT Ime + ' ' + Prezime AS ImePrezime
FROM Kupac
WHERE Ime = 'Ana' OR
Ime = 'Tamara' AND
GradID = 2

SELECT Ime + ' '+ Prezime AS ImePrezime
FROM Kupac
WHERE Prezime LIKE 'D%re%'

SELECT TOP 50 PERCENT Prezime
FROM Kupac
WHERE Ime = 'Jack'