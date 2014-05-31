USE AdventureWorksOBP

SELECT *,
ROUND (CijenaBezPDV, 2)
FROM Proizvod;

SELECT *,
ROUND (UkupnaCijena, 2) AS Zaokruzena,
FLOOR (CijenaPoKomadu) AS Najnizi,
CEILING (CijenaPoKomadu) AS Najvisi
FROM Stavka;

SELECT ABS(-91);

SELECT *,
SQUARE (IDStavka) AS Square,
SQRT (IDStavka) AS Root
FROM Stavka;

SELECT ROUND(RAND() * 100, 0);

SELECT GETDATE();

SELECT IDRacun, BrojRacuna, KupacID, KomercijalistID, KreditnaKarticaID, Komentar,
YEAR (DatumIzdavanja) AS Year,
MONTH (DatumIzdavanja) AS Month
FROM Racun
WHERE KupacID = 377;

SELECT *,
DATEDIFF(YEAR, DatumIzdavanja, GETDATE()) AS Years,
DATEDIFF(MONTH, DatumIzdavanja, GETDATE()) AS Months,
DATEDIFF(DAY, DatumIzdavanja, GETDATE()) AS Days
FROM Racun
WHERE KupacID = 377;

SELECT DATEADD(DAY, 12000, GETDATE());

SELECT *,
CHARINDEX('A', Naziv, 0) AS A
FROM Proizvod;

SELECT *,
LEN(Naziv) AS Length
FROM Proizvod;

SELECT IDProizvod, BrojProizvoda, MinimalnaKolicinaNaSkladistu, CijenaBezPDV, PotkategorijaID,
UPPER(Naziv) AS Naziv,
LOWER(Boja) AS Colour
FROM Proizvod;

SELECT LTRIM(RTRIM('            text        '));

SELECT IDProizvod, BrojProizvoda, MinimalnaKolicinaNaSkladistu, CijenaBezPDV, PotkategorijaID, Boja,
REVERSE(Naziv) AS RevName
FROM Proizvod;

SELECT *,
SUBSTRING(Naziv, 0, 5) AS First5
FROM Proizvod;

SELECT Naziv,
CAST (CijenaBezPDV AS int) AS Integer, 
CAST (CijenaBezPDV AS nvarchar(max)) AS String
FROM Proizvod;

SELECT ISDATE('today') AS String,
ISDATE('2011-08-05') AS Date;

SELECT ISNUMERIC('abcd') AS String,
ISNUMERIC ('42.42') AS Number;

SELECT Naziv,
ISNULL(Boja, 'NOT DEFINED') AS Boja
FROM Proizvod;