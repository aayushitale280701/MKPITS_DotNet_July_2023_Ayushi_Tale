Create table Salespeople(Ord_No int , Purch_Amt decimal,  Ord_Date varchar(20)   , Customer_ID int , Salesman_ID int)
Insert into Salespeople values(70001,150.5,'2012-10-05',3005,5002)
Insert into Salespeople values(70009,270.65,'2012-09-10',3001,5005)
Insert into Salespeople values(70002,65.26,'2012-10-05',3002,5001)
Insert into Salespeople values(70004,110.5,'2012-08-17',3009,5003)
Insert into Salespeople values(70007,948.5,'2012-09-10',3005,5002)
Insert into Salespeople values(70005,2400.6,'2012-07-27',3007,5001)
Insert into Salespeople values(70008,5760,'2012-09-10',3002,5001)
Select distinct Salesman_ID from Salespeople
