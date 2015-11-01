CREATE DATABASE PPPK5
GO

USE PPPK5
GO

CREATE TABLE Kolegij
(
	IDKolegij int PRIMARY KEY IDENTITY(1,1),
	Naziv nvarchar(max) NOT NULL,
	Semestaar int NOT NULL,
	ECTS int NOT NULL
)
GO

CREATE TABLE Nastavnik
(
	IDNastavnik int PRIMARY KEY IDENTITY(1, 1),
	Ime nvarchar(max) NOT NULL,
	Prezime nvarchar(max) NOT NULL
)
GO

CREATE TABLE KolegijNastavnik
(
	IDKolegij int FOREIGN KEY REFERENCES Kolegij (IDKolegij),
	IDNastavnik int FOREIGN KEY REFERENCES Nastavnik (IDNastavnik)
)
GO

CREATE TABLE Student
(
	IDStudent int PRIMARY KEY IDENTITY(1, 1),
	Ime nvarchar(max) NOT NULL,
	Prezime nvarchar(max) NOT NULL
)
GO

CREATE TABLE KolegijStudent
(
	IDStudent int FOREIGN KEY REFERENCES Student (IDStudent),
	IDKolegij int FOREIGN KEY REFERENCES Kolegij (IDKolegij)
)
GO

INSERT INTO Kolegij (Naziv, Semestaar, ECTS)
VALUES ('Java', 5, 5), ('Pristup podacima iz programskog koda', 5, 6),
('Oblikovanje baza podataka', 3, 6), ('Razvoj web aplikacija', 4, 7)
GO

INSERT INTO Nastavnik (Ime, Prezime)
VALUES ('Danijel', 'Kucak'), ('Bojan', 'Fulanovic'), ('Goran', 'Dambic')
GO

INSERT INTO KolegijNastavnik (IDKolegij, IDNastavnik)
VALUES (1, 1), (2, 2), (3, 3), (4, 2)
GO

INSERT INTO Student (Ime, Prezime)
VALUES ('Matija', 'Huremovic'), ('Matija', 'Derk')
GO

INSERT INTO KolegijStudent (IDStudent, IDKolegij)
VALUES (1, 1), (1, 2), (2, 3), (2, 1)
GO