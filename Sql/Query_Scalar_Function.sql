create table Employee(Empid int primary key,
                      empcontact varchar(50),
					  empname varchar (50),
					  empcity varchar(50)
					  );
insert into Employee values (1,	123,'	amit','	nagpur')
insert into Employee values (2,	222,'	raj',	'mumbai')
insert into Employee values (3,	333,'	dhanush',	'nagpur')

select * from Employee

create function fun_emp2
    (  
       @EmpContact varchar(50),  
       @EmpName varchar(50),  
       @EmpCity varchar(50)  
    )  
    returns varchar(150)  
    as  
    begin return(select @EmpContact+ ' ' +@EmpName + ' ' + @EmpCity)  
    end  

select dbo.Employee(empcontact,empname,empcity) as 'detail' from Employee
