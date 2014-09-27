USE RentACar

INSERT INTO Proizvodjac
VALUES ('Opel'), ('Honda'), ('Volkswagen')
GO

INSERT INTO Model
VALUES ('Astra', 1), ('Vectra', 1), ('Civic', 2), ('Legend', 2),
('Polo', 3), ('Golf', 3), ('Passat', 3)
GO

INSERT INTO Kategorija
VALUES ('Benzinski motor'), ('Dizelski motor')
GO

INSERT INTO Vozilo
VALUES ('ZG-4242-AB', 1, 1, 5000, 180.00), ('ZG-2424-HU', 2, 1, 7500, 190.00),
('ZG-1869-MR', 3, 1, 2200, 165.00), ('SK-1337-AA', 4, 1, 11000, 150.00),
('VŽ-8844-NE', 5, 1, 8900, 175.00), ('ZG-0299-BB', 6, 1, 4200, 142.00),
('ZG-9922-FO', 7, 1, 10000, 186.00), ('ZG-6056-CC', 1, 2, 17000, 190.00),
('ZG-1995-JR', 2, 2, 15000, 176.00)

INSERT INTO Klijent
VALUES ('Iva', 'Ivić', 'iva.ivic@mail.com', '098-1234567', 'Ulica 1', 'Zagreb', 'Hrvatska'),
('Maja', 'Majić', 'maja.majic@mail.com', '099-1234567', 'Ulica 2', 'Zagreb', 'Hrvatska'),
('Miro', 'Mirić', 'miro.miric@mail.com', '091-1234567', 'Ulica 3', 'Zagreb', 'Hrvatska')

INSERT INTO StatusVozila
VALUES ('Placeno'), ('Preuzeto'), ('Vraceno')

INSERT INTO Najam
VALUES (2, 1, 1, '2014-01-01', '2014-01-05'), (3, 1, 2, '2014-01-18', '2014-01-20'),
(2, 2, 3, '2014-04-22', '2014-04-26'), (3, 2, 4, '2014-05-20', '2014-05-21'),
(2, 3, 1, '2014-04-20', '2014-04-30'), (3, 3, 1, '2014-08-01', '2014-08-03')