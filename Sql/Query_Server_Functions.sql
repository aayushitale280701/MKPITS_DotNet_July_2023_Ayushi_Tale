create table Employee11(EmpId int primary key,
                      EmpName varchar(50),
					  EmpContact bigint,
					  EmpEmail varchar(50),
					  EmpDepartment varchar(50),
					  EmpCity varchar (50),
					  Salary float
					  );
insert into Employee11 values(1, 'Rakesh',9924194054,'rakeshchavda404@gmail.com','Computer','Ahmedabad',20000.00)
insert into Employee11 values(2, 'Karan',9874563217,'kk@gmail.com','Account','Mumbai',19000.00)
insert into Employee11 values(3, 'Keval',94055788345,'keval@gmail.com','Managment','Mumbai',17000.00)
insert into Employee11 values(4, 'Rina',87875542147,'rina@gmail.com','Account','Ahmedabad',25000.00)
insert into Employee11 values(5, 'Rahul',9632587415,'rahul707@gmail.com','Account','Visakhapatnam',15000.00)
insert into Employee11 values(6, 'Rohan',8523697415,'rohan123@gmail.com','Computer','Visakhapatnam',10000.00)
insert into Employee11 values(7, 'Ketan',7531594864,'ketan09@gmail.com','Computer','Mumbai',16000.00)
insert into Employee11 values(8, 'Aman',9632587417,'aman@gmail.com','Managment','Ahmedabad',23000.00)

select * from Employee11

Create function FUN1(@EmpName VARCHAR (50),
                      @EmpEmail VARCHAR (50),
					  @EmpCity VARCHAR (50))      
    returns   varchar (50)
    as      
    begin return (select @EmpName  + ' : ' + @EmpEmail + ' : ' + @EmpCity )     
end;

select dbo.FUN1(EmpName,EmpEmail,EmpCity) as 'Employee Details' from Employee11