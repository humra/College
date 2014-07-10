USE AdventureWorksOBP

SELECT Naziv, ROUND(CijenaBezPDV, 2) AS Cijena
FROM Proizvod

SELECT Naziv, ROUND(CijenaBezPDV, 2) AS Cijena,
FLOOR(CijenaBezPDV) AS Floor, 
CEILING(CijenaBezPDV) AS Ceiling
FROM Proizvod

SELECT Naziv, IDProizvod, SQRT(IDProizvod) AS Root,
POWER(IDProizvod, 2) AS Square
FROM Proizvod