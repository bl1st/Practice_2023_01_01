CREATE DATABASE PcComponentsDB

USE PcComponentsDB
GO

CREATE TABLE ProductCategory --CPU, GPU, HDD, SSD, Cooler, Power supply
(
ID INT PRIMARY KEY IDENTITY,
CategoryName NVARCHAR(250) not null
)
GO 


CREATE TABLE Characteristic
(
ID INT PRIMARY KEY IDENTITY,
CharacteristicName NVARCHAR (200) NOT NULL
)




CREATE TABLE Product
(
ID INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(250) NOT NULL,
CategoryID INT NOT NULL FOREIGN KEY REFERENCES ProductCategory(ID)
)
GO


CREATE TABLE CategoryCharacteristic
(
CategoryID INT FOREIGN KEY REFERENCES ProductCategory(ID),
CharacteristicID INT FOREIGN KEY REFERENCES Characteristic(ID)
PRIMARY KEY(CategoryID,CharacteristicID)
)
GO


CREATE TABLE ProductCharacteristic
(
ProductID INT FOREIGN KEY REFERENCES Product(ID),
CharacteristicID INT FOREIGN KEY REFERENCES Characteristic(ID),
CharacteristicValue NVARCHAR(200) NOT NULL
)
GO


Create table ProductPrice
(
ID INT PRIMARY KEY IDENTITY,
ProductID INT FOREIGN KEY REFERENCES Product(ID) NOT NULL,
Price decimal (16,4) NOT NULL
)
go
