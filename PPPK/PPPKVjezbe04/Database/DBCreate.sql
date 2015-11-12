CREATE DATABASE PPPK4
GO

USE PPPK4
GO

CREATE TABLE Kolegij
(
	IDKolegij int PRIMARY KEY IDENTITY(1, 1),
	Naziv nvarchar(max) NOT NULL,
	Semestar int NOT NULL,
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

INSERT INTO Kolegij (Naziv, Semestar, ECTS)
VALUES ('Pristup podacima iz programskog koda', 5, 5),
('Java 1', 4, 7), ('Razvoj web aplikacija', 4, 5),
('Oblikovanje baza podataka', 3, 6)

INSERT INTO Nastavnik (Ime, Prezime)
VALUES ('Danijel', 'Kucak'), ('Bojan', 'Fulanovic'),
('Goran', 'Djambic')

INSERT INTO KolegijNastavnik (IDKolegij, IDNastavnik)
VALUES (1, 2), (2, 1), (3, 2), (4, 3)

INSERT INTO Student (Ime, Prezime)
VALUES ('Matija', 'Huremovic')

INSERT INTO KolegijStudent (IDKolegij, IDStudent)
VALUES (1, 1), (2, 1), (3, 1), (4, 1)