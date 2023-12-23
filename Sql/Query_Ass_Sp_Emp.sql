create table employee (EmpID int,Emp_Name varchar(20), Designation varchar (25), Salary int)
insert into employee values (111,'Ayushi','HR',350000)
insert into employee values (112,'Rajesh','Manager',20000)
insert into employee values (113,'Ayush','HR',550000)
insert into employee values (114,'Rajeshree','CEO',80000)
insert into employee values (115,'Prachi','HR',250000)
insert into employee values (116,'Nayra','Manager',20000)
insert into employee values (117,'Om','CEO',450000)
insert into employee values (118,'Ritu','HR',60000)
--drop table employee
-------------------------------------------------------------------------
--Q6
create proc emp 
as
begin
select * from employee
where Designation='Manager' and Salary=20000
end;
exec emp
--------------------------------------------------------------------------
--Q8
create proc emp1
as
begin
select * from employee
where  Salary>20000 and Salary<50000
end;
exec emp1
drop proc emp1