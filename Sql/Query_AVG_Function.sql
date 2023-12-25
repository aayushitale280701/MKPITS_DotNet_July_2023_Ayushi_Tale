create table Employee_Info(Name varchar(50),
                           Occupation varchar(50),
						   Working_Date Date,
						   Working_Hours int,
						   Salary int
						   );
insert into Employee_Info  values ('Jolly Evans','HR', '2020-10-04',9,25000)
insert into Employee_Info  values ('Brayden Simmons','Engineer', '2020-10-04',12,65000)
insert into Employee_Info  values ('Rose Huges','Writer', '2020-10-04',13,35000)
insert into Employee_Info  values ('Laura Paul','Manager', '2020-10-04',10,45000)
insert into Employee_Info  values ('Diego Simmons','Teacher', '2020-10-04',12,30000)
insert into Employee_Info  values ('Antonio Bennet','Writer', '2020-10-04',13,35000)
insert into Employee_Info  values ('Laura Paul','Manager', '2020-11-05',10,42000)
insert into Employee_Info  values ('Antonio Bennet','Writer', '2020-11-05',9,38000)
insert into Employee_Info  values ('Rose Huges','Writer', '2020-11-05',12,36000)
insert into Employee_Info  values ('Jolly Evans','HR', '2020-11-05',11,30000)

SELECT * FROM Employee_Info

SELECT AVG(Working_Hours) AS "Average Working Hours"   
FROM Employee_Info;   

SELECT AVG (Working_Hours) AS "Average Working Hours"
FROM Employee_Info 
WHERE Occupation = 'Writer';


