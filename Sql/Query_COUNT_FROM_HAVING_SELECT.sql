Create table mkp (ID int Primary Key, SName varchar(20), CourseName varchar(20), City varchar(20))
Insert into mkp values (11, 'Ayushi', 'Dotnet', 'Nagpur')
Insert into mkp values (12, 'Akash', 'Dotnet', 'Nagpur')
Insert into mkp values (13, 'Mayuri', 'C', 'Nagpur')
Insert into mkp values (14, 'Prachi', 'C++', 'Nagpur')
Insert into mkp values (15, 'Laucky', 'Java', 'Nagpur')
Insert into mkp values (16, 'Vrushali', 'Dotnet', 'Nagpur')
select City,COUNT(*) from mkp
where CourseName = 'c'
group by City

select City,COUNT(*) from mkp
where CourseName = 'Dotnet'
group by City
having COUNT(*) > 2
