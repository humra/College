CREATE DATABASE PPPKVjezbe06
GO

USE PPPKVjezbe06
GO

CREATE TABLE Drzava
(
	IDDrzava int PRIMARY KEY IDENTITY(1, 1),
	Naziv nvarchar(max) NOT NULL
)
GO

CREATE TABLE Grad
(
	IDGrad int PRIMARY KEY IDENTITY(1, 1),
	Naziv nvarchar(max) NOT NULL,
	IDDrzava int FOREIGN KEY REFERENCES Drzava (IDDrzava)
)
GO

INSERT INTO Drzava (Naziv)
VALUES ('Hrvatska'), ('Engleska'), ('Njemacka'), ('Rusija'), ('Japan')
GO

INSERT INTO Grad (Naziv, IDDrzava)
VALUES ('Zagreb', 1), ('Velika Gorica', 1), ('Rijeka', 1),
('London', 2), ('Oxford', 2), ('Munchen', 3), ('Stuttgart', 3), ('Moskva', 4), ('Tokyo', 5)
GO