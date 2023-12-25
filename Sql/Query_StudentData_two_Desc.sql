Create table Student11 (StdRollNo int, StdName varchar(20), Gender varchar(20),City varchar(20))
Insert into Student11 values (11, 'Ayushi', 'Female', 'MZR')
Insert into Student11 values (13, 'Om', 'Male', 'MZR')
Insert into Student11 values (14, 'Avinash', 'Male', 'Akola')
Insert into Student11 values (12, 'Prachi', 'Female', 'Nagpur')
Insert into Student11 values (16, 'Ayush', 'Male', 'Pune')
Insert into Student11 values (15, 'chandrima', 'Female', 'Mumbai')
Insert into Student11 values (18, 'Rita', 'Female', 'Shegao')
Insert into Student11 values (17, 'Prachi', 'Female', 'Bandara')
Insert into Student11 values (19, 'Rita', 'Female', 'Shegao')
Insert into Student11 values (20, 'Prachi', 'Female', 'Bandara')

select * from student11 order by StdRollNo 
select * from student11 order by StdName
select * from student11 where City='MZR' order by StdName
select * from Student11 where City='MZR' order by StdName desc


