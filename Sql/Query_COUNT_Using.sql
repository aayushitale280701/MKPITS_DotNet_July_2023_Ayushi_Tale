Create table Student (ID int, StdName varchar(20), Course varchar(20), City varchar(20))
insert into Student values (111,'Ayushi','Dotnet','Nagpur')
insert into Student values (112,'Akash','Dotnet','Nagpur')
insert into Student values (113,'Ayushree','Dotnet','Nagpur')
insert into Student values (114,'Pooja','Dotnet','Nagpur')
insert into Student values (115,'Prachi','Dotnet','Nagpur')
insert into Student values (116,'Murunal','Java','Nagpur')
insert into Student values (117,'Avinash','Java','Nagpur')
insert into Student values (118,'Mathili','Java','Nagpur')
insert into Student values (119,'Mathili','C','Nagpur')
insert into Student values (120,'Mathili','C#','Nagpur')
select * from Student order by ID
select Course, COUNT(*) from Student where City='Nagpur' group by Course