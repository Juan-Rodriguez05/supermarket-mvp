USE Supermarket

CREATE TABLE Products
(
    Product_Id INT IDENTITY (100000,1) PRIMARY KEY,
    Product_Name NVARCHAR(100) NOT NULL,
    Product_Price INT NOT NULL,
    Product_Stock INT NOT NULL,
    Category_Name NVARCHAR(50) NOT NULL,
    Provider_Id INT NOT NULL
)