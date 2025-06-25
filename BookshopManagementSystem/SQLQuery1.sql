CREATE DATABASE BookshopDB;
GO

USE BookshopDB;

CREATE TABLE Books (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100),
    Author NVARCHAR(100),
    Price FLOAT
);
