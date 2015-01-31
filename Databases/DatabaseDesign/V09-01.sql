USE AdventureWorksOBP
GO

--Zadatak 1.
ALTER FUNCTION ObrnutiIspis
(
	@naziv nvarchar(max)
)
RETURNS nvarchar(max)
AS
BEGIN
	DECLARE  @povrat nvarchar(max)

	IF (LEN(@naziv) % 2 = 0) 
	BEGIN
		SET @povrat = SUBSTRING(@naziv, (LEN(@naziv) / 2) + 1, LEN(@naziv)) + SUBSTRING(@naziv, 0, (LEN(@naziv) / 2) + 1)
	END
	ELSE
	BEGIN
		SET @povrat = SUBSTRING(@naziv, (LEN(@naziv) / 2) + 1, LEN(@naziv)) + SUBSTRING(@naziv, 1, LEN(@naziv) / 2)
	END

	RETURN @povrat
END
GO

SELECT dbo.ObrnutiIspis('Test') AS Ime

SELECT dbo.ObrnutiIspis(Naziv)
FROM Proizvod


--Zadatak 2.
ALTER FUNCTION BrojA
(
	@ulaz nvarchar(max)
)
RETURNS int
BEGIN
	DECLARE @broj int
	SET @broj = LEN(@ulaz) - LEN(REPLACE(@ulaz, 'a', '')) 

	RETURN @broj
END
GO

SELECT dbo.BrojA('Humra') AS test

SELECT Naziv, dbo.BrojA(Naziv) AS SlovaA
FROM Proizvod


--Zadatak 3.
ALTER FUNCTION Samoglasnici
(
	@ulaz nvarchar(max)
)
RETURNS int
BEGIN
	DECLARE @broj int
	DECLARE @curr int
	DECLARE @znak char(1)

	SET @curr = 1
	SET @broj = 0

	WHILE @curr <= LEN(@ulaz) BEGIN
		SET @znak = SUBSTRING(@ulaz, @curr, 1)

		IF @znak IN ('a', 'e', 'i', 'o', 'u')
			SET @broj = @broj + 1

		SET @curr = @curr + 1
	END

	RETURN @broj
END
GO

SELECT dbo.Samoglasnici('Humra') AS test

SELECT Naziv, dbo.Samoglasnici(Naziv) AS Samoglasnici
FROM Proizvod