Create table Fees (RollNo int ,Names varchar(20),Course varchar(20), Amount bigint, Paid_Date varchar(50))
Insert into fees values(451,'Ayushi','Dotnet',5000,'2023-Jan-1')
Insert into fees values(452,'Rajesh','Java',6000,'2023-Nov-22')
Insert into fees values(453,'Aradhaya','Dotnet',5000,'2023-Feb-28')
Insert into fees values(454,'Ayush','Dotnet',5000,'2023-May-16')
Insert into fees values(455,'Raju','Java',6000,'2023-Nov-30')
Insert into fees values(456,'Sayli','Dotnet',5000,'2023-Jul-25')
Insert into fees values(457,'Prachi','Dotnet',5000,'2023-Jun-21')
Insert into fees values(458,'Vrushali','Java',6000,'2023-Nov-15')
Insert into fees values(459,'Kreena','Dotnet',5000,'2023-Jun-24')
Insert into fees values(460,'Mayuri','Dotnet',5000,'2023-Nov-1')
Insert into fees values(461,'Priya','Java',6000,'2023-Nov-22')
Insert into fees values(462,'Avinash','Dotnet',5000,'2023-Jun-28')
select * from fees Where Paid_Date BETWEEN '1-Nov-2023' AND '30-Nov-2023' 
select * from fees order by Paid_Date 
