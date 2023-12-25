create table Employee(EmpId int primary key,
                      EmpName varchar(50),
					  EmpContact bigint,
					  EmpEmail varchar(50),
					  EmpDepartment varchar(50),
					  EmpCity varchar (50),
					  Salary float
					  );
insert into Employee values(1, 'Rakesh',9924194054,'rakeshchavda404@gmail.com','Computer','Ahmedabad',20000.00)
insert into Employee values(2, 'Karan',9874563217,'kk@gmail.com','Account','Mumbai',19000.00)
insert into Employee values(3, 'Keval',94055788345,'keval@gmail.com','Managment','Mumbai',17000.00)
insert into Employee values(4, 'Rina',87875542147,'rina@gmail.com','Account','Ahmedabad',25000.00)
insert into Employee values(5, 'Rahul',9632587415,'rahul707@gmail.com','Account','Visakhapatnam',15000.00)
insert into Employee values(6, 'Rohan',8523697415,'rohan123@gmail.com','Computer','Visakhapatnam',10000.00)
insert into Employee values(7, 'Ketan',7531594864,'ketan09@gmail.com','Computer','Mumbai',16000.00)
insert into Employee values(8, 'Aman',9632587417,'aman@gmail.com','Managment','Ahmedabad',23000.00)

select * from Employee

Create function Fun_EmployeeInfo()      
    returns table       
    as      
    return(select * from Employee  )     
select * from Fun_EmployeeInfo()