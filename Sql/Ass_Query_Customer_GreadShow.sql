Create table Customers(
                 Customer_ID int,
				 Cust_Name varchar(20),
				 City varchar(20),
				 Grade int,
				 Salesman_ID int)

insert into Customers values (3002,'Nick Rimando','New York',100,5001)        
insert into Customers values (3007,'Brad Davis','New York',200,5001)
insert into Customers values(3005,'Graham Zusi','California',200,5002)
insert into Customers values(3008,'Julian Green','London',300,5002)
insert into Customers values(3004,'Fabian Johnson','Paris',300,5006)
insert into Customers values(3009,'Geoff Cameron','Berlin',100,5003)
insert into Customers values(3003,'Jozy Altidor','Moscow',200,5007)
Select Customer_ID,Cust_Name,City,Grade,Salesman_ID from Customers Where Grade='200'
