--SELECT SUBSTRING('http://www.racunarstvo.hr', 1, 4) AS Protokol,
--SUBSTRING('http://www.racunarstvo.hr', 8, 3) AS Servis,
--SUBSTRING('http://www.racunarstvo.hr', 12, 11) AS Naziv,
--SUBSTRING('http://www.racunarstvo.hr',24, 2) AS Domena

--SELECT UPPER('www.racunarstvo.hr') AS Upper,
--LOWER('WWW.RACUNARSTVO.HR') AS Lower

--SELECT LTRIM(RTRIM('            Pero ide u sumu              ')) AS Trim

--SELECT ISNUMERIC('abcd')

--SELECT ISNUMERIC('67.55')

--SELECT ISNUMERIC('67,55')

--USE LosFilm2

--SELECT LEFT(ImePrezime, CHARINDEX(' ', ImePrezime, 0)) AS Ime,
--SUBSTRING(ImePrezime, CHARINDEX(' ', ImePrezime, 0), 50) AS Prezime
--FROM Clan