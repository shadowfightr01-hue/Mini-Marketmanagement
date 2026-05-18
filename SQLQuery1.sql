CREATE DATABASE minimarketdb;
GO

USE minimarketdb;
GO

CREATE TABLE Category
(
    CatId INT PRIMARY KEY,
    CatName VARCHAR(100),
    CatDesc VARCHAR(200)
);

CREATE TABLE Product
(
    ProdId INT PRIMARY KEY,
    ProdName VARCHAR(100),
    ProdPrice INT,
    ProdQty INT,
    ProdCat VARCHAR(100)
);

CREATE TABLE Seller
(
    SellerId INT PRIMARY KEY,
    SellerName VARCHAR(100),
    SellerAge INT,
    SellerPhone VARCHAR(50),
    SellerPass VARCHAR(100)
);

CREATE TABLE AdminTbl
(
    AdminId INT PRIMARY KEY,
    AdminName VARCHAR(100),
    AdminPass VARCHAR(100)
);

INSERT INTO AdminTbl
VALUES (1, 'admin', 'admin123');

INSERT INTO Seller VALUES
(1,'seller1',22,'01711111111','1234');