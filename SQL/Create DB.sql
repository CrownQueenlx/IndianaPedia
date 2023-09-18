CREATE DATABASE IndianaPedia;
GO
CREATE schema [IndianaPedia].[sysDB]
go
CREATE TABLE [sysDB].[AttractionTypes](
 [TypeId] INT PRIMARY KEY,
 [TypeName] VARCHAR(150)
);
INSERT INTO [sysDB].[AttractionTypes]([TypeId],[TypeName])
VALUES 
    (1,'Museum'),
    (2,'Amusement Park'),
    (3, 'Zoo'),
    (4,'Fair Ground'),
    (5, 'Aquarium');
    GO
create TABLE [sysDB].[FrisbeeGolf](
[Id] int not NULL PRIMARY KEY IDENTITY(1,1),
[Location] VARCHAR not NULL,
[Rating] int Check (Rating >= 0 and Rating <= 5), 
[Comments] varchar(250),
[NicName] VARCHAR(25),
);
GO
Create TABLE [sysDB].[Attractions] (
[Id] int not null PRIMARY KEY IDENTITY (1,1),
[Name] VARCHAR(25) not null,
[Location] VARCHAR not null,
[Rating] int Check (Rating >= 0 and Rating <= 5),
[Type] int REFERENCES sysDB.AttractionTypes ([TypeId]), 
[Cost] FLOAT
);
GO
CREATE TABLE [sysDB].[MajorCities](
[Id] int not null IDENTITY (1,1),
[Name] varchar(50) not null,
[Population] int not null
);


