CREATE TABLE Costomer11 (CustID INT PRIMARY KEY IDENTITY,
                       CustName VARCHAR (50),
					   Tel_No BIGINT
					   );

CREATE TABLE Orders11 (Order_ID VARCHAR (50),
                     Order_Date Date,
					 Cust_ID INT,
					 Product_Name VARCHAR(50),
					 Quantity INT,
					 Rates Int
					 )

INSERT INTO Costomer11 VALUES ('Ayushi',987564231)
INSERT INTO Costomer11 VALUES ('Ayush',569872314)
INSERT INTO Costomer11 VALUES ('Naitik',5637564231)
INSERT INTO Costomer11 VALUES ('Om',567755314)
INSERT INTO Costomer11 VALUES ('Avinash',321464231)
INSERT INTO Costomer11 VALUES ('Nayra',966872314)

INSERT INTO Orders11 VALUES ('11','2023-10-23',1,'Pen',5,10)
INSERT INTO Orders11 VALUES ('12','2023-12-22',4,'Book',7,100)
INSERT INTO Orders11 VALUES ('13','2023-12-10',3,'Pencil',10,5)
INSERT INTO Orders11 VALUES ('14','2023-12-11',5,'Long Book',20,130)

SELECT Costomer11.CustID,Costomer11.CustName,Costomer11.Tel_No,
       Orders11.Order_ID,Orders11.Order_Date,Orders11.Product_Name,Orders11.Quantity,Orders11.Rates
FROM Costomer11 INNER JOIN Orders11
ON Costomer11.CustID = Orders11.Cust_ID;
