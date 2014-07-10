USE AdventureWorksOBP

SELECT IDRacun, YEAR(DatumIzdavanja) AS Year, MONTH(DatumIzdavanja) AS Month
FROM Racun
WHERE KupacID = 377

SELECT IDRacun,
DATEDIFF(year, DatumIzdavanja, GETDATE()) AS Years,
DATEDIFF(month, DatumIzdavanja, GETDATE()) AS Months,
DATEDIFF(day, DatumIzdavanja, GETDATE()) AS Days
FROM Racun
WHERE KupacID = 377

SELECT DATEADD(day, 12000, GETDATE())