Create table Employee (EmpID int Primary Key identity(1,1), EmpName varchar(20))
insert into Employee(EmpName) values('Avi')
select * from Employee

insert into Employee(EmpName) values('Rajesh')
select * from Employee

delete from Employee where EmpID=1

insert into Employee(EmpName) values('Rajesh123')
delete from Employee
select * from Employee

insert into Employee(Empname) values('Rajesh123')
Select * from Employee 