CREATE DATABASE autodb;

USE autodb;

CREATE TABLE [Users] (
    id int PRIMARY KEY IDENTITY,
    [name] nvarchar(50) NOT NULL,
    username nvarchar(50) NOT NULL,
    email nvarchar(50) NOT NULL,
    [password] nvarchar(50) NOT NULL
);

CREATE TABLE CarCharacteristics (
    id int NOT NULL PRIMARY KEY IDENTITY(1,1),
    mark varchar(50) NOT NULL,
    model varchar(50) NOT NULL,
    enginecapacity float NOT NULL,
    driveunit varchar(50) NOT NULL,
    transmissiontype varchar(50) NOT NULL,
    fueltype varchar(50) NOT NULL
);

CREATE TABLE Cars (
  id int PRIMARY KEY IDENTITY(1,1),
  characteristicsid int,
  identfier NVARCHAR(50) NOT NULL,
  mileage int NOT NULL,
  creationYear int NOT NULL,
  color varchar(50) NOT NULL,
  priceforhour FLOAT NOT NULL,
  FOREIGN KEY (characteristicsid) REFERENCES CarCharacteristics(id)
);


CREATE TABLE Clients (
	id int PRIMARY KEY IDENTITY,
    [name] nvarchar(50) NOT NULL,
    email nvarchar(50) NOT NULL,
    phonenumber nvarchar(50) NOT NULL,
	passportnumber nvarchar(50) UNIQUE NOT NULL,
);

CREATE TABLE RentLists (
	id int PRIMARY KEY IDENTITY,
	clientid INT NOT NULL UNIQUE,
	carid INT NOT NULL UNIQUE,
	renttime INT NOT NULL,
	dateofrent DATETIME,
	endofrent DATETIME,
	totalprice float,
	FOREIGN KEY (clientid) REFERENCES Clients(id),
	FOREIGN KEY (carid) REFERENCES Cars(id)
);

CREATE TABLE ArchiveRentLists (
	id int PRIMARY KEY IDENTITY,
	[name] nvarchar(50) NOT NULL,
    email nvarchar(50) NOT NULL,
	phonenumber nvarchar(50) NOT NULL,
	passportnumber nvarchar(50) NOT NULL,
	mileage int NOT NULL,
	creationYear int NOT NULL,
	color varchar(50) NOT NULL,
	priceforhour FLOAT NOT NULL,
	mark varchar(50) NOT NULL,
    model varchar(50) NOT NULL,
    enginecapacity float NOT NULL,
    driveunit varchar(50) NOT NULL,
    transmissiontype varchar(50) NOT NULL,
    fueltype varchar(50) NOT NULL,
	renttime INT NOT NULL,
	totalprice float,
);

CREATE TABLE ArchiveUsers (
	id int PRIMARY KEY IDENTITY,
    [name] nvarchar(50) NOT NULL,
    username nvarchar(50) NOT NULL,
    email nvarchar(50) NOT NULL,
    [password] nvarchar(50) NOT NULL

);

CREATE TABLE ArchiveCars (
	id int PRIMARY KEY IDENTITY,
	mark varchar(50) NOT NULL,
    model varchar(50) NOT NULL,
    enginecapacity float NOT NULL,
    driveunit varchar(50) NOT NULL,
    transmissiontype varchar(50) NOT NULL,
    fueltype varchar(50) NOT NULL,
	mileage int NOT NULL,
	creationYear int NOT NULL,
	color varchar(50) NOT NULL,
	priceforhour FLOAT NOT NULL,
);




GO
CREATE OR ALTER TRIGGER OnUserDelete
ON [Users]
FOR DELETE
AS
INSERT INTO ArchiveUsers ([name], username, email, [password])
SELECT [name], username, email, [password]
FROM [Users]

GO
CREATE OR ALTER TRIGGER OnRentListsInsert
ON RentLists
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO RentLists(carid, clientid, renttime, dateofrent, endofrent, totalprice) 
    SELECT i.carid, i.clientid, i.renttime, CURRENT_TIMESTAMP, DATEADD(HOUR, i.renttime, CURRENT_TIMESTAMP), c.priceforhour * i.renttime
    FROM inserted i
    JOIN Cars c ON c.id = i.carid
END

GO
CREATE OR ALTER TRIGGER OnRentListsUpdate
ON RentLists
INSTEAD OF UPDATE
AS
BEGIN
    UPDATE rl SET
        rl.carid = i.carid,
        rl.clientid = i.clientid,
        rl.renttime = i.renttime,
		rl.endofrent = DATEADD(HOUR, i.renttime, CURRENT_TIMESTAMP),
        rl.totalprice = c.priceforhour * i.renttime
    FROM RentLists rl
    JOIN INSERTED i ON i.id = rl.id
    JOIN Cars c ON c.id = i.carid
END

GO
CREATE OR ALTER TRIGGER OnRentListDelete
ON RentLists
INSTEAD OF DELETE
AS
INSERT INTO ArchiveRentLists ([name], email, phonenumber, passportnumber, mark, model, enginecapacity, driveunit, transmissiontype, fueltype,
mileage, creationYear, color, priceforhour, renttime, totalprice)
SELECT Clients.[name], Clients.email, Clients.phonenumber, Clients.passportnumber, CarCharacteristics.mark, CarCharacteristics.model,
CarCharacteristics.enginecapacity, CarCharacteristics.driveunit, 
CarCharacteristics.transmissiontype, CarCharacteristics.fueltype, Cars.mileage, Cars.creationYear, Cars.color, Cars.priceforhour, renttime, totalprice
FROM RentLists
JOIN Clients ON Clients.id = RentLists.clientid
JOIN Cars ON Cars.id = RentLists.carid 
JOIN CarCharacteristics ON CarCharacteristics.id = Cars.characteristicsid 
DELETE FROM RentLists WHERE id IN (SELECT id FROM DELETED);

GO
CREATE OR ALTER TRIGGER OnCarDelete
ON Cars
INSTEAD OF DELETE
AS
INSERT INTO ArchiveCars (mark, model, enginecapacity, driveunit, transmissiontype, fueltype, mileage, creationYear, color, priceforhour)
SELECT CarCharacteristics.mark, CarCharacteristics.model, CarCharacteristics.enginecapacity, CarCharacteristics.driveunit,
CarCharacteristics.transmissiontype, CarCharacteristics.fueltype, mileage, creationYear, color, priceforhour
FROM Cars
JOIN CarCharacteristics ON CarCharacteristics.id = Cars.characteristicsid 
DELETE FROM RentLists WHERE carid IN (SELECT id FROM DELETED);
DELETE FROM Cars WHERE id IN (SELECT id FROM DELETED);

CREATE OR ALTER VIEW RentListView(mark, model, identfier, name, passportnumber,
renttime, dateofrent, totalprice) AS SELECT cc.mark, cc.model, c.identfier, cl.name, cl.passportnumber, rl.renttime, rl.dateofrent, rl.totalprice
FROM RentLists rl
JOIN Cars c ON rl.carid = c.id
JOIN CarCharacteristics cc ON c.characteristicsid = cc.id
JOIN Clients cl ON rl.clientid = cl.id;

CREATE OR ALTER PROCEDURE RentListReport(@startDate datetime, @endDate datetime)
AS
BEGIN
SET NOCOUNT ON;
SELECT cc.mark, cc.model, c.identfier, cl.name, cl.passportnumber, rl.renttime, rl.dateofrent, rl.endofrent, rl.totalprice
FROM RentLists rl
JOIN Cars c ON rl.carid = c.id
JOIN CarCharacteristics cc ON c.characteristicsid = cc.id
JOIN Clients cl ON rl.clientid = cl.id
WHERE CAST(@startDate AS date) = CAST(rl.dateofrent AS date) AND CAST(@endDate AS date) = CAST(rl.endofrent AS date);
END;

GO
CREATE OR ALTER TRIGGER OnCarCharacteristicsDelete
ON CarCharacteristics
INSTEAD OF DELETE
AS
DELETE FROM Cars WHERE characteristicsid IN (SELECT id FROM DELETED);
DELETE FROM CarCharacteristics WHERE id IN (SELECT id FROM DELETED);

INSERT INTO CarCharacteristics (mark, model, enginecapacity, driveunit, transmissiontype, fueltype)
VALUES
('Toyota', 'Corolla', 1.6, '�������� ������', '��������������', '������'),
('Honda', 'Civic', 1.5, '�������� ������', '������������ ', '������'),
('Volkswagen', 'Golf', 1.4, '�������� ������', '��������������', '������'),
('Ford', 'Fiesta', 1.0, '�������� ������', '������������ ', '������'),
('BMW', '3 Series', 2.0, '������ ������', '��������������', '������'),
('Mercedes-Benz', 'C-Class', 2.0, '������ ������', '��������������', '������'),
('Audi', 'A4', 2.0, '�������� ������', '��������������', '������'),
('Lexus', 'ES', 2.5, '�������� ������', '��������������', '������'),
('Nissan', 'Altima', 2.5, '�������� ������', '�����������', '������'),
('Hyundai', 'Elantra', 2.0, '�������� ������', '��������������', '������'),
('Kia', 'Optima', 2.0, '�������� ������', '�������������� ', '������'),
('Mazda', '6', 2.5, '�������� ������', '��������������', '������'),
('Subaru', 'Impreza', 2.0, '������ ������', '������������ ', '������'),
('Jeep', 'Wrangler', 3.6, '������ ������', '������������ ', '������'),
('Chevrolet', 'Camaro', 3.6, '������ ������', '��������������', '������'),
('Dodge', 'Challenger', 3.6, '������ ������', '��������������', '������'),
('Tesla', 'Model S', 100.0, '������ ������', '��������������', '�������������'),
('Porsche', '911', 3.0, '������ ������', '��������������', '������'),
('Ferrari', '458 Italia', 4.5, '������ ������', '��������������', '������'),
('Lamborghini', 'Aventador', 6.5, '������ ������', '��������������', '������');

INSERT INTO Cars (characteristicsid, identfier ,mileage, creationYear, color, priceforhour)
VALUES
(1, '7B1A', 50000, 2018, '�������', 10.0),
(2, 'SB8A', 70000, 2017, '�����', 8.5),
(3, '4B2V', 60000, 2016, '�����������', 9.0),
(4, '5BAS', 80000, 2015, '�����', 7.5),
(5, 'YZ29', 90000, 2014, '������', 12.0),
(6, '92TR', 40000, 2019, '�����', 14.5),
(7, '77GH', 45000, 2020, '�����', 13.0),
(8, '438F', 30000, 2021, '�������', 16.0),
(9, '09OP', 55000, 2018, '�����������', 7.0),
(10, '1111', 65000, 2017, '������', 8.0),
(11, 'FFFF', 50000, 2016, '�����', 6.5),
(12, 'HT34', 60000, 2015, '�������', 9.5),
(13, 'RETU', 75000, 2014, '�����', 10.5),
(14, 'RT43', 40000, 2019, '�����', 15.0),
(15, '324F', 35000, 2020, '�����', 12.5),
(16, 'GFH2', 55000, 2021, '������', 17.0),
(17, '23JH', 80000, 2018, '�������', 20.0),
(18, '89FH', 60000, 2017, '�����������', 18.0),
(19, 'JJU2', 70000, 2016, '�����', 16.5),
(20, '2KSM', 90000, 2015, '������', 21.0);

INSERT INTO [Users] ([name], username, email, [password])
VALUES
('���� ������', 'ivanp', 'ivan.petrov@example.com', '������123'),
('���� �������', 'annai', 'anna.ivanova@example.com', '12345678'),
('������ �������', 'mihails', 'msidorov@example.com', '������0'),
('����� �������', 'elenak', 'ekozlova@example.com', '��������'),
('������� ��������', 'dmitryn', 'dnikolaev@example.com', 'qwerty'),
('����� ��������', 'olgas', 'osmirnova@example.com', '������1'),
('������� ��������', 'alexeyv', 'avasiliev@example.com', '�����'),
('������� �������', 'nataliai', 'natalia.ivanova@example.com', '������2'),
('����� ��������', 'igork', 'ikuznetsov@example.com', 'qazwsx'),
('������ �����', 'andreyp', 'apopov@example.com', '������3'),
('�������� ���������', 'svetlanam', 'smikhailova@example.com', '111111'),
('����� �������', 'alenaz', 'azaitseva@example.com', 'password'),
('��������� ������', 'vladislavk', 'vkrylov@example.com', 'parol123'),
('�������� ��������', 'kristinan', 'knovikova@example.com', 'p@ssword'),
('������� �������', 'evgeniys', 'esokolov@example.com', 'qwerty123'),
('������� ��������', 'nadezhda_k', 'nkuzmina@example.com', '������4'),
('���� ������', 'glebv', 'gvolkov@example.com', 'password123'),
('����� �������', 'alinap', 'apetrova@example.com', '������5'),
('����� �������', 'deniss', 'dsmirnov@example.com', '123qwe'),
('������ ������', 'oksana_i', 'oilina@example.com', '������6');

INSERT INTO Clients ([name], email, phonenumber, passportnumber)
VALUES
('���� ������', 'ivan.ivanov@example.com', '555-1234', 'ABC123'),
('���� ��������', 'anna.smirnova@example.com', '555-5678', 'DEF456'),
('������� ������', 'dmitry.petrov@example.com', '555-9876', 'GHI789'),
('����� ���������', 'elena.kuznetsova@example.com', '555-4321', 'JKL012'),
('���� �������', 'peter.sidirov@example.com', '555-8765', 'MNO345'),
('������ �������', 'lyubov.chernova@example.com', '555-2345', 'PQR678'),
('������� �������', 'timofey.novikov@example.com', '555-6789', 'STU901'),
('����� ��������', 'olga.morozova@example.com', '555-3456', 'VWX234'),
('��������� ������', 'alexander.kozlov@example.com', '555-7890', 'YZA567'),
('������ �������', 'marina.volkova@example.com', '555-3210', 'BCD890'),
('�������� �������', 'vladimir.andreev@example.com', '555-7654', 'EFG123'),
('�������� ��������', 'svetlana.kovaleva@example.com', '555-2109', 'HIJ456'),
('������ �������', 'maxim.lebedev@example.com', '555-1593', 'KLM789'),
('������� ������', 'nadezhda.belova@example.com', '555-4680', 'NOP012'),
('���� �������', 'ilya.makarov@example.com', '555-8027', 'QRS345'),
('������� ���������', 'evgeniya.alekseeva@example.com', '555-2468', 'TUV678'),
('�������� �������', 'grigory.smirnov@example.com', '555-6802', 'WXY901'),
('��������� ��������', 'ekaterina.borisova@example.com', '555-0246', 'ZAB234'),
('����� ��������', 'artem.chernyshev@example.com', '555-4680', 'CDE567'),
('���� ���������', 'nina.vasilieva@example.com', '555-8027', 'FGH890');

INSERT INTO RentLists (clientid, carid, renttime)
VALUES
(1, 3, 5),
(2, 2, 3),
(3, 5, 2),
(4, 1, 1),
(5, 6, 4),
(6, 4, 6),
(7, 8, 8),
(8, 9, 3),
(9, 7, 2),
(10, 12, 5),
(11, 10, 3),
(12, 15, 1),
(13, 13, 4),
(14, 18, 6),
(15, 11, 8),
(16, 14, 2),
(17, 20, 3),
(18, 17, 5),
(19, 16, 7),
(20, 19, 2);




