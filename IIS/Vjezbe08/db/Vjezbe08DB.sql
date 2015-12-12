CREATE DATABASE IISVjezbe08
GO

USE IISVjezbe08
GO

CREATE TABLE Student
(
	IDStudent int PRIMARY KEY IDENTITY(1, 1),
	Ime nvarchar(max),
	Prezime nvarchar(max),
	JMBAG nvarchar(max),
	GodinaStudija int,
)

CREATE TABLE Kolegij
(
	IDKolegij int PRIMARY KEY IDENTITY(1, 1),
	Naziv nvarchar(max),
	Nositelj nvarchar(max),
	ECTS int
)

CREATE TABLE Upis
(
	IDUpis int PRIMARY KEY IDENTITY(1, 1),
	StudentID int FOREIGN KEY REFERENCES Student (IDStudent),
	KolegijID int FOREIGN KEY REFERENCES Kolegij (IDKolegij)
)