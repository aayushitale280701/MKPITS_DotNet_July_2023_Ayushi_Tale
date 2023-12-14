Create table Student(First_Name varchar(20),Last_Name varchar(20),Id int)
insert into Student Values('Ayushi','Tale',45)
insert into Student values('Reetu','Ingole',42)
insert into Student values('Om','Tale',13)
insert into Student values('Rajesh','Gawande',12)
insert into Student values('Prachi','Thorat',16)
select * from Student Where First_Name='Rajesh' and ID=12
select * from Student where Last_Name='Ingole' and First_Name='Reetu'
select * from Student where Last_Name='Ingole' or ID>12