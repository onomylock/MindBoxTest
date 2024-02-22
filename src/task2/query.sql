CREATE TABLE IF NOT EXISTS Products (
  ID int NOT NULL AUTO_INCREMENT,
  Name varchar(100) NOT NULL,
  PRIMARY KEY(ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS Categories (
  ID int NOT NULL AUTO_INCREMENT,
  Name varchar(100) NOT NULL,
  PRIMARY KEY(ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS Products_Categories (
  Product_ID int,
  Category_ID int DEFAULT(0),
  PRIMARY KEY(Product_ID, Category_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO Products (Name) VALUES
('Orange'),
('Tomato'),
('Cucumber'),
('Calt'),
('Sugar'),
('Banana'),
('Coffe');

INSERT INTO Categories (Name) VALUES
('Vegetables'),
('Fruits');

INSERT INTO Products_Categories(Product_ID, Category_ID) VALUES
(1, 2),
(2, 1),
(3, 1),
(4, default),
(5, default),
(6, 2),
(7, default);

Select p.Name as product_name, c.Name as category_name 
from Products_Categories as pc
left join Products as p ON p.ID = pc.Product_ID
left join Categories as c ON c.ID = pc.Category_ID;