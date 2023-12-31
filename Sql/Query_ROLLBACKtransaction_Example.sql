CREATE TABLE Product(Product_Id INT PRIMARY KEY,
                     Producgt_Name VARCHAR (50),
					 Price INT,
					 Quentity INT
					 )
INSERT INTO Product VALUES (111,'Mobile',15000,10),
                           (112,'Laptop',35000,2),
						   (113,'Mouse',500,10),
						   (114,'Keyboard',4000,5)
SELECT * FROM Product


BEGIN TRANSACTION
UPDATE Product SET Price = 6000 WHERE Product_Id = 114
DELETE FROM Product WHERE Product_Id = 113

ROLLBACK TRANSACTION