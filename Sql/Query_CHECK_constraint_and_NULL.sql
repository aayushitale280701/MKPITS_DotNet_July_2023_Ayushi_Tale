CREATE TABLE Product5(ProductID INT IDENTITY PRIMARY KEY,
                      ProductName VARCHAR(255) not null ,
					  UnitPrice DEC(10,2) CONSTRAINT PositivePrice CHECK (UnitPrice > 0));

INSERT INTO Product5 (ProductName, UnitPrice) VALUES ('T.V',499);
INSERT INTO Product5 (ProductName, UnitPrice) VALUES ('Headphone' , 599)

SELECT * FROM Product5