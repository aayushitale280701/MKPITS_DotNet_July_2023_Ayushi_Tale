Create table mkp (ID int Primary Key, SName varchar(20), CourseName varchar(20), City varchar(20))
Insert into mkp values (11, 'Ayushi', 'Dotnet', 'Nagpur')
Insert into mkp values (12, 'Akash', 'Dotnet', 'Nagpur')
Insert into mkp values (13, 'Mayuri', 'Dotnet', 'Nagpur')
Insert into mkp values (14, 'Prachi', 'Dotnet', 'Nagpur')
Insert into mkp values (15, 'Laucky', 'Dotnet', 'Nagpur')
Insert into mkp values (16, 'Vrushali', 'Dotnet', 'Nagpur')
select * from mkp
select CourseName, COUNT(*) from mkp where City='Nagpur' group by CourseName


