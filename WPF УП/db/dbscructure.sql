CREATE DATABASE PcComponentsDB
go

USE PcComponentsDB
GO

CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
CategoryName NVARCHAR(100) NOT NULL)
GO


CREATE TABLE Products
(
Id INT PRIMARY KEY IDENTITY,
CategoryId INT FOREIGN KEY REFERENCES Categories(ID),
ProductName NVARCHAR(300) NOT NULL,
[Text] NVARCHAR(MAX) NOT NULL
)
GO

CREATE TABLE AttributeGroups(
Id INT PRIMARY KEY IDENTITY,
GroupName NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Attributes
(
Id INT PRIMARY KEY IDENTITY,
AttributeGroupID INT FOREIGN KEY REFERENCES AttributeGroups(Id),
AttributeName NVARCHAR(100) NOT NULL)
GO

CREATE TABLE [Values](
ID INT PRIMARY KEY IDENTITY,
ProductID INT FOREIGN KEY REFERENCES Products(Id),
AttributeID INT FOREIGN KEY REFERENCES Attributes(Id),
Value nvarchar(200) NOT NULL
)
GO



