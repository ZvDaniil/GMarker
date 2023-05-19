USE [master]
GO

— Создание базы данных
CREATE DATABASE [UnitsDatabase]
GO

USE [UnitsDatabase]
GO

— Создание таблицы "Units"
CREATE TABLE [dbo].[Units]
(
[Id] INT IDENTITY(1,1) PRIMARY KEY,
[Latitude] FLOAT NOT NULL,
[Longitude] FLOAT NOT NULL,
[Name] NVARCHAR(50) NOT NULL
)
GO

— Наполнение таблицы "Units" данными
INSERT INTO [dbo].[Units] ([Latitude], [Longitude], [Name])
VALUES (55.7558, 37.6173, N'Unit 1'),
(59.9386, 30.3141, N'Unit 2'),
(51.5074, -0.1278, N'Unit 3')
GO
