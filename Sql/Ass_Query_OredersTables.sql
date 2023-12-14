Create table Orders (Ord_No int, Purch_Amt decimal, Ord_Date varchar(20), Customer_ID int, Salesman_ID int) 
Insert into Orders values(70001,150.5,'2012-10-05',3005,5002)
Insert into Orders values(70009,270.65,'2012-09-10' , 3001,5005)
Insert into Orders values(70002,65.26,'2012-10-05',3002 ,5001)
Insert into Orders values(70004,110.5,'2012-08-17 ',3009,5003)
Insert into Orders values(70007,948.5 ,'2012-09-10 ',3005,5002)
Insert into Orders values(70005,2400.6,'2012-07-27 ',3007 ,5001)
Insert into Orders values(70008,5760,'2012-09-10',3002,5001)
select Ord_No,Purch_Amt,Ord_Date,Customer_Id,Salesman_ID from Orders 

/*Q :-- From the following table, write a SQL query to find the orders, which are delivered by a 
salesperson of ID. 5001. Return ord_no, ord_date, purch_amt.*/

Select Ord_No,Ord_Date,Purch_Amt From Orders Where Salesman_ID='5001'