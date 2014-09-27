USE AdventureWorksOBP

SELECT CHARINDEX('A', Naziv, 0)
FROM Proizvod

SELECT Naziv, LEN(Naziv) AS Length
FROM Proizvod

SELECT UPPER(Naziv) AS Naziv,
LOWER(Boja) AS Boja
FROM Proizvod

SELECT RTRIM(LTRIM('         tekst            '))

SELECT REVERSE(Naziv) AS Naziv
FROM Proizvod

SELECT SUBSTRING(Naziv, 1, 5)
FROM Proizvod

SELECT Naziv, ISNULL(Boja, 'NIJE DEFINIRANA')
FROM Proizvod

SELECT ISDATE('danas')

SELECT ISDATE('2011-08-15')

SELECT ISDATE('15.08.2011.')