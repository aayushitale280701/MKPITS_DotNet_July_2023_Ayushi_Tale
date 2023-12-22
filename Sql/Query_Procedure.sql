CREATE TABLE PRODUCT (Orderid INT , Custid INT, Orderdate DATE, Productname VARCHAR(20),Qty INT)

INSERT INTO  PRODUCT VALUES (1,1,'2022-2-2','Mouse',5)
INSERT INTO  PRODUCT VALUES (1,1,'2022-2-2','Keyboard',4)
INSERT INTO  PRODUCT VALUES (2,2,'2022-2-2','Desktop',3)
INSERT INTO  PRODUCT VALUES (2,2,'2022-2-2','Ram',4)
INSERT INTO  PRODUCT VALUES (3,3,'2022-2-2','Laptop',2)
INSERT INTO  PRODUCT VALUES (4,3,'2022-1-2','Mouse',6)
INSERT INTO  PRODUCT VALUES (5,4,'2022-2-2','Mouse',7)
INSERT INTO  PRODUCT VALUES (6,4,'2022-2-2','Ram',6)
INSERT INTO  PRODUCT VALUES (7,5,'2022-2-2','Desktop',2)
INSERT INTO  PRODUCT VALUES (7,5,'2022-2-2','Ram',5)


CREATE procedure Prod2
AS 
BEGIN
SELECT * FROM PRODUCT
END;
EXEC prod2


CREATE procedure Prod3
AS 
BEGIN
SELECT * FROM PRODUCT WHERE Custid='1'
END;
EXEC Prod3



