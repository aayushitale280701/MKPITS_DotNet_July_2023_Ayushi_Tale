Create table Customer (ProductNo int, ProductName varchar(20), Quntity int, Rate int)
insert into Customer values (101,'T.V',2,30000)
insert into Customer values (102,'Mouse',1,300)
insert into Customer values (103,'CPU',3,2000)
insert into Customer values (105,'Keyboard',6,900)
insert into Customer values (104,'Headphones',8,1500)
select * from Customer order by ProductNo
select * from Customer where ProductName='Keyboard'
select * from Customer where ProductNo=103
select * from Customer where ProductNo>104
select * from Customer where ProductNo>102 and ProductNo<104
select * from Customer where ProductName='amit' and Quntity=200