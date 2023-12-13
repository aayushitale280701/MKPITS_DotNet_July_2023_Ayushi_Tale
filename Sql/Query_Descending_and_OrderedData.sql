Create table Employee (ID int, EmpName varchar(20), EmpSalary int, Designation varchar(20))
insert into Employee values (222,'Ayushi',30000,'HR')
insert into Employee values (221,'Om',40000,'Maneger')
insert into Employee values (224,'Ritu',30000,'HR')
insert into Employee values (223,'Prachi',50000,'Manager')
insert into Employee values (225,'Aradhaya',40000,'HR')
select * from Employee order by EmpName
select * from Employee order by ID desc