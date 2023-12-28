create table Products (Product_ID int primary key,
                       Product_Name varchar (25),
					   Price int,
					   Quentity int
					   )

insert into Products values (111, 'Mobile', 10000, 10) 
insert into Products values (112, 'Laptop', 20000, 15) 
insert into Products values (113, 'Mouse', 300, 20)
insert into Products values (114, 'Hard Disk', 4000, 25)  
insert into Products values (115, 'Speaker', 3000, 20)  

select * from Products

begin transaction
insert into Products values (116,'Head Phone',1000,5)
update Products set Price = 800  where Product_ID = 113

