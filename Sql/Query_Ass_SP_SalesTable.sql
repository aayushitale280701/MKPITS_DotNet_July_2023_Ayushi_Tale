Create table Salespeople1 (Salesman_ID int, Names varchar(20), City varchar(20),Amount int)
Insert into Salespeople1 values (5001,' James Hoog' ,'New York ',2000)
Insert into Salespeople1 values (5002,'Nail Knite','Paris',3500)
Insert into Salespeople1 values (5005,'Pit Alex','London',10000)
Insert into Salespeople1 values (5006,'Mc Lyon','Paris',1000)
Insert into Salespeople1 values (5007,'Paul Adam','Rome',8000)
Insert into Salespeople1 values (5003,'Lauson Hen','San Jose',6000)
Select * From Salespeople1

-----------------------------------------------------------------------------------------------------
----Q5
create proc Sp2
as
begin
select * from Salespeople1
where Amount >1000 and Amount < 10000
end;
Exec Sp2
