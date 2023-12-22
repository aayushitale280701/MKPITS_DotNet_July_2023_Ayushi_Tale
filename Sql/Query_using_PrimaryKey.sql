CREATE TABLE Order_Details1(OrderID INT,
                            ProductID INT, 
							Quantity INT , PRIMARY KEY (OrderID, ProductID
							))

INSERT INTO Order_Details1 VALUES (11,1,5)
INSERT INTO Order_Details1 VALUES (12,2,4)
INSERT INTO Order_Details1 VALUES (13,3,3)
INSERT INTO Order_Details1 VALUES (14,4,6)

SELECT * FROM Order_Details1