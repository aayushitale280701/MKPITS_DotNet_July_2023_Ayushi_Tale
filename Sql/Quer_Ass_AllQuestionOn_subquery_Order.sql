--Q1
CREATE TABLE Customers1
                      (Customer_ID INT,
					  Customer_Name VARCHAR(100),
					  City VARCHAR(100),
					  Grade INT,
					  Salesman_ID INT)

INSERT INTO Customers1 VALUES(3002,'Nick Rimando','New York',100,5001),
                             (3007,'Brad Davis','New York',200,5001),
                             (3005,'Graham Zusi','California',200,5002),
                             (3008,'Julian Green','London',300,5002),
                             (3004,'Fabian Johnson','Paris',300,5006),
                             (3009,'Geoff Cameron','Berlin',100,5003),
                             (3003,'Jozy Altidor','Moscow',200,5007),
                             (3001,'Brad Guzan','London',NULL,5005)

SELECT * FROM Customers1
----------------------------------------------------------------------------------
Create table Salesman (Salesman_ID int, 
                       Names varchar(20),
					   City varchar(20),
					   Commission float
					   )

Insert into Salesman values (5001,' James Hoog' ,'New York ',0.15)
Insert into Salesman values (5002,'Nail Knite','Paris',0.13)
Insert into Salesman values (5005,'Pit Alex','London',0.11)
Insert into Salesman values (5006,'Mc Lyon','Paris',0.14)
Insert into Salesman values (5007,'Paul Adam','Rome',0.13)
Insert into Salesman values (5003,'Lauson Hen','San Jose',0.12)
Select * From Salesman
--------------------------------------------------------------------------
create table Orders (Ord_No  int,
                    Purch_Amt float,
					Ord_Date date,
					Customer_ID  int,
					Salesman_id int 
					)

insert into Orders values (70001, 150.5,'2012-10-05',3000,5002)
insert into Orders values (70009,270.65,'2012-09-10',3001,5005)
insert into Orders values (70002,65.26,'2012-10-05',3002,5001)
insert into Orders values (70004,110.5,'2012-08-17',3009,5003)
insert into Orders values (70007,948.5,'2012-09-10',3005,5002)
insert into Orders values (70005,2400.6,'2012-07-27',3007,5001)
insert into Orders values (70008,5760,'2012-09-10',3002,5001)
insert into Orders values (70010,1983.43,'2012-10-10',3004,5006)
insert into Orders values (70003,2480.4 ,'2012-10-10',3009,5003)
insert into Orders values (70012,250.45,'2012-06-27',3008,5002)
insert into Orders values (70011,75.29,'2012-08-17',3003,5007)
insert into Orders values (70013,3045.6,'2012-04-25',3002,5001)

select * from Orders 
where Salesman_id = (SELECT Salesman_ID FROM Salesman WHERE Names = 'Paul Adam');
----------------------------------------------------------------------------------
--Q2
select * from Orders 
where Salesman_id = (SELECT Salesman_ID FROM Salesman WHERE City = 'London')
-----------------------------------------------------------------------------------
--Q3
select * from Orders 
where Salesman_id = (SELECT Distinct Salesman_ID FROM Orders WHERE Customer_ID = 3007)
---------------------------------------------------------------------------------------
--Q4
Select * from Orders
where Purch_Amt > (Select avg(Purch_Amt) From Orders 
where Ord_Date = '10/10/2012');
-----------------------------------------------------------------------------------
--Q5
select * from Orders 
where Salesman_id = (SELECT Salesman_ID FROM Salesman WHERE City = 'New York')
------------------------------------------------------------------------------------
--Q6
select Commission from Salesman 
where Salesman_ID in (SELECT Salesman_ID From Customers1 Where City = 'Paris')
--------------------------------------------------------------------------------------
--Q7
Select * from Customers1
where Customer_ID = (select Salesman_ID-2001 from Salesman where Names = 'Mc Lyon')
---------------------------------------------------------------------------------------
--Q8
select Grade, COUNT  (*)
from Customers1 GROUP BY Grade HAVING Grade > 
(select avg (Grade) from Customers1 where city = 'New York')
---------------------------------------------------------------------------------------
--Q9
Select Ord_No, Purch_Amt, Ord_Date , Salesman_ID from Orders 
Where Salesman_id  in (select Salesman_id from Salesman Where Commission = (select max (Commission)
From Salesman ));
-----------------------------------------------------------------------------------------
--Q10
SELECT b.*, a.Customer_Name FROM Orders b, Customers1 a
WHERE a.Customer_ID = b.Customer_ID
AND b.Ord_Date='2012-08-17';
-----------------------------------------------------------------------------------------
--Q11
select Salesman_ID , Names from Salesman a 
where 1 < (select count(*) from Customers1 where Salesman_ID = a.Salesman_ID);
-----------------------------------------------------------------------------------
--Q12
select * from Orders a
where Purch_Amt > (select avg (Purch_Amt ) from Orders b where b.Customer_ID = a.Customer_ID);
---------------------------------------------------------------------------------------------
--Q13
select * from Orders a
Where Purch_Amt >= (select avg (Purch_Amt) from Orders b where b.Customer_ID = a.Customer_ID);
----------------------------------------------------------------------------------------------
--Q14
SELECT Ord_Date, SUM (Purch_Amt) FROM Orders a GROUP BY Ord_Date
HAVING SUM (Purch_Amt) > (SELECT 1000.00 + MAX(Purch_Amt) 
FROM Orders b  WHERE a.Ord_Date = b.Ord_Date);
---------------------------------------------------------------------------------
--Q15
SELECT Customer_ID, Customer_Name, City FROM Customers1
WHERE EXISTS (SELECT * FROM Customers1  WHERE city='London');
--------------------------------------------------------------------------
--Q16
select * from Salesman where Salesman_ID In (SELECT DISTINCT Salesman_ID 
FROM Customers1 a WHERE EXISTS (SELECT * FROM Customers1 b 
WHERE b.Salesman_ID=a.Salesman_ID AND b.Customer_Name<>a.Customer_Name));
--------------------------------------------------------------------------------
--Q17
SELECT * FROM Salesman WHERE Salesman_ID IN (SELECT DISTINCT Salesman_ID  FROM Customers1 a 
WHERE NOT EXISTS (SELECT * FROM Customers1 b WHERE a.Salesman_ID=b.Salesman_ID AND a.Customer_Name<>b.Customer_Name));
------------------------------------------------------------------------------------------------------
--Q18

SELECT * FROM Salesman a 
WHERE EXISTS (SELECT * FROM Customers1 b WHERE a.Salesman_ID=b.Salesman_ID AND 1<             
(SELECT COUNT (*) FROM Orders WHERE Orders.Customer_ID = b.Customer_ID));
--------------------------------------------------------------------------------
--Q19
SELECT * FROM Salesman WHERE City=ANY (SELECT City FROM Customers1);
-----------------------------------------------------------------------------
--Q20
SELECT * FROM Salesman  WHERE City IN (SELECT City FROM Customers1);
--------------------------------------------------------------------------
--Q21
SELECT * FROM Salesman a WHERE EXISTS (SELECT * FROM Customers1 WHERE  a.Names  < b.Customer_Name);
---------------------------------------------------------------------------------
--Q22
SELECT * FROM Customers1 WHERE Grade > ANY (SELECT Grade FROM Customers1 WHERE  City < 'New York');
---------------------------------------------------------------------------------------
--Q23
SELECT * FROM Orders WHERE purch_amt > ANY (SELECT purch_amt FROM orders WHERE  ord_date='2012/09/10');
------------------------------------------------------------------------------------------------------
--Q24
SELECT * FROM Orders WHERE Purch_Amt < ANY (SELECT Purch_Amt FROM Orders a, Customers1 b
WHERE  a.Customer_ID=b.Customer_ID AND b.City='London');
--------------------------------------------------------------------------------------------
--Q25
SELECT * FROM Orders WHERE Purch_Amt < (SELECT MAX (Purch_Amt) FROM Orders a, Customers1 b
WHERE  a.Customer_ID=b.Customer_ID AND b.City='London');




