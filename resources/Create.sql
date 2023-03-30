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
('Toyota', 'Corolla', 1.6, 'Передний привод', 'Автоматическая', 'Бензин'),
('Honda', 'Civic', 1.5, 'Передний привод', 'Механическая ', 'Бензин'),
('Volkswagen', 'Golf', 1.4, 'Передний привод', 'Автоматическая', 'Бензин'),
('Ford', 'Fiesta', 1.0, 'Передний привод', 'Механическая ', 'Бензин'),
('BMW', '3 Series', 2.0, 'Задний привод', 'Автоматическая', 'Дизель'),
('Mercedes-Benz', 'C-Class', 2.0, 'Задний привод', 'Автоматическая', 'Бензин'),
('Audi', 'A4', 2.0, 'Передний привод', 'Автоматическая', 'Дизель'),
('Lexus', 'ES', 2.5, 'Передний привод', 'Автоматическая', 'Бензин'),
('Nissan', 'Altima', 2.5, 'Передний привод', 'Вариаторная', 'Бензин'),
('Hyundai', 'Elantra', 2.0, 'Передний привод', 'Автоматическая', 'Бензин'),
('Kia', 'Optima', 2.0, 'Передний привод', 'Автоматическая ', 'Дизель'),
('Mazda', '6', 2.5, 'Передний привод', 'Автоматическая', 'Бензин'),
('Subaru', 'Impreza', 2.0, 'Полный привод', 'Механическая ', 'Бензин'),
('Jeep', 'Wrangler', 3.6, 'Полный привод', 'Механическая ', 'Бензин'),
('Chevrolet', 'Camaro', 3.6, 'Задний привод', 'Автоматическая', 'Бензин'),
('Dodge', 'Challenger', 3.6, 'Задний привод', 'Автоматическая', 'Бензин'),
('Tesla', 'Model S', 100.0, 'Полный привод', 'Автоматическая', 'Электричество'),
('Porsche', '911', 3.0, 'Задний привод', 'Автоматическая', 'Бензин'),
('Ferrari', '458 Italia', 4.5, 'Задний привод', 'Автоматическая', 'Бензин'),
('Lamborghini', 'Aventador', 6.5, 'Полный привод', 'Автоматическая', 'Бензин');

INSERT INTO Cars (characteristicsid, identfier ,mileage, creationYear, color, priceforhour)
VALUES
(1, '7B1A', 50000, 2018, 'Красный', 10.0),
(2, 'SB8A', 70000, 2017, 'Синий', 8.5),
(3, '4B2V', 60000, 2016, 'Серебрянный', 9.0),
(4, '5BAS', 80000, 2015, 'Белый', 7.5),
(5, 'YZ29', 90000, 2014, 'Черный', 12.0),
(6, '92TR', 40000, 2019, 'Серый', 14.5),
(7, '77GH', 45000, 2020, 'Белый', 13.0),
(8, '438F', 30000, 2021, 'Красный', 16.0),
(9, '09OP', 55000, 2018, 'Серебрянный', 7.0),
(10, '1111', 65000, 2017, 'Черный', 8.0),
(11, 'FFFF', 50000, 2016, 'Белый', 6.5),
(12, 'HT34', 60000, 2015, 'Красный', 9.5),
(13, 'RETU', 75000, 2014, 'Синий', 10.5),
(14, 'RT43', 40000, 2019, 'Серый', 15.0),
(15, '324F', 35000, 2020, 'Белый', 12.5),
(16, 'GFH2', 55000, 2021, 'Черный', 17.0),
(17, '23JH', 80000, 2018, 'Красный', 20.0),
(18, '89FH', 60000, 2017, 'Серебрянный', 18.0),
(19, 'JJU2', 70000, 2016, 'Белый', 16.5),
(20, '2KSM', 90000, 2015, 'Черный', 21.0);

INSERT INTO [Users] ([name], username, email, [password])
VALUES
('Иван Петров', 'ivanp', 'ivan.petrov@example.com', 'пароль123'),
('Анна Иванова', 'annai', 'anna.ivanova@example.com', '12345678'),
('Михаил Сидоров', 'mihails', 'msidorov@example.com', 'пароль0'),
('Елена Козлова', 'elenak', 'ekozlova@example.com', 'дайвойти'),
('Дмитрий Николаев', 'dmitryn', 'dnikolaev@example.com', 'qwerty'),
('Ольга Смирнова', 'olgas', 'osmirnova@example.com', 'пароль1'),
('Алексей Васильев', 'alexeyv', 'avasiliev@example.com', 'добро'),
('Наталья Иванова', 'nataliai', 'natalia.ivanova@example.com', 'пароль2'),
('Игорь Кузнецов', 'igork', 'ikuznetsov@example.com', 'qazwsx'),
('Андрей Попов', 'andreyp', 'apopov@example.com', 'пароль3'),
('Светлана Михайлова', 'svetlanam', 'smikhailova@example.com', '111111'),
('Алена Зайцева', 'alenaz', 'azaitseva@example.com', 'password'),
('Владислав Крылов', 'vladislavk', 'vkrylov@example.com', 'parol123'),
('Кристина Новикова', 'kristinan', 'knovikova@example.com', 'p@ssword'),
('Евгений Соколов', 'evgeniys', 'esokolov@example.com', 'qwerty123'),
('Надежда Кузьмина', 'nadezhda_k', 'nkuzmina@example.com', 'пароль4'),
('Глеб Волков', 'glebv', 'gvolkov@example.com', 'password123'),
('Алина Петрова', 'alinap', 'apetrova@example.com', 'пароль5'),
('Денис Смирнов', 'deniss', 'dsmirnov@example.com', '123qwe'),
('Оксана Ильина', 'oksana_i', 'oilina@example.com', 'пароль6');

INSERT INTO Clients ([name], email, phonenumber, passportnumber)
VALUES
('Иван Иванов', 'ivan.ivanov@example.com', '555-1234', 'ABC123'),
('Анна Смирнова', 'anna.smirnova@example.com', '555-5678', 'DEF456'),
('Дмитрий Петров', 'dmitry.petrov@example.com', '555-9876', 'GHI789'),
('Елена Кузнецова', 'elena.kuznetsova@example.com', '555-4321', 'JKL012'),
('Петр Сидоров', 'peter.sidirov@example.com', '555-8765', 'MNO345'),
('Любовь Чернова', 'lyubov.chernova@example.com', '555-2345', 'PQR678'),
('Тимофей Новиков', 'timofey.novikov@example.com', '555-6789', 'STU901'),
('Ольга Морозова', 'olga.morozova@example.com', '555-3456', 'VWX234'),
('Александр Козлов', 'alexander.kozlov@example.com', '555-7890', 'YZA567'),
('Марина Волкова', 'marina.volkova@example.com', '555-3210', 'BCD890'),
('Владимир Андреев', 'vladimir.andreev@example.com', '555-7654', 'EFG123'),
('Светлана Ковалева', 'svetlana.kovaleva@example.com', '555-2109', 'HIJ456'),
('Максим Лебедев', 'maxim.lebedev@example.com', '555-1593', 'KLM789'),
('Надежда Белова', 'nadezhda.belova@example.com', '555-4680', 'NOP012'),
('Илья Макаров', 'ilya.makarov@example.com', '555-8027', 'QRS345'),
('Евгения Алексеева', 'evgeniya.alekseeva@example.com', '555-2468', 'TUV678'),
('Григорий Смирнов', 'grigory.smirnov@example.com', '555-6802', 'WXY901'),
('Екатерина Борисова', 'ekaterina.borisova@example.com', '555-0246', 'ZAB234'),
('Артем Чернышев', 'artem.chernyshev@example.com', '555-4680', 'CDE567'),
('Нина Васильева', 'nina.vasilieva@example.com', '555-8027', 'FGH890');

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




