CREATE TABLE Categories
(
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

INSERT INTO Categories (Id, Name)
VALUES
    (1, 'Категория A'),
    (2, 'Категория B'),
    (3, 'Категория C');

CREATE TABLE Products
(
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);

INSERT INTO Products (Id, Name, Price)
VALUES
    (1, 'Продукт 1', 10.99),
    (2, 'Продукт 2', 15.49),
    (3, 'Продукт 3', 7.89),
    (4, 'Продукт 4', 10.5);

CREATE TABLE ProductCategories
(
    ProductId INT,
    CategoryId INT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

INSERT INTO ProductCategories (ProductId, CategoryId)
VALUES
    (1, 1),     
    (1, 2), 
    (2, 1), 
    (3, 3),
    (1, 3), 
    (3, 1)