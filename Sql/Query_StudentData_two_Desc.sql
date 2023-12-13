Create table Student (StdRollNo int, StdName varchar(20), Gender varchar(20),City varchar(20))
Insert into Student values (11, 'Ayushi', 'Female', 'MZR')
Insert into Student values (13, 'Om', 'Male', 'MZR')
Insert into Student values (14, 'Avinash', 'Male', 'Akola')
Insert into Student values (12, 'Prachi', 'Female', 'Nagpur')
Insert into Student values (16, 'Ayush', 'Male', 'Pune')
Insert into Student values (15, 'chandrima', 'Female', 'Mumbai')
Insert into Student values (18, 'Rita', 'Female', 'Shegao')
Insert into Student values (17, 'Prachi', 'Female', 'Bandara')
select * from student order by StdRollNo 
--select * from student order by StdName
select * from student where City='MZR' order by StdName
select * from student where City='MZR' order by StdName desc


