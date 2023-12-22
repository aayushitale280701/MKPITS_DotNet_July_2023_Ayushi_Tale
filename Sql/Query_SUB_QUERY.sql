create table orders (orderid int , custid int, orderdate date,productname varchar(20),qty int)


exec sp_help customer;

insert into orders values(1,1,'2022-2-2','Mouse',5)
insert into orders values(1,1,'2022-2-2','Keyboard',5)
insert into orders values(2,2,'2022-2-2','Desktop',5)
insert into orders values(2,2,'2022-2-2','Ram',5)
insert into orders values(3,3,'2022-2-2','Laptop',5)
insert into orders values(4,3,'2022-1-2','Mouse',5)
insert into orders values(5,4,'2022-2-2','Mouse',5)
insert into orders values(6,4,'2022-2-2','Ram',5)
insert into orders values(7,5,'2022-2-2','Desktop',5)
insert into orders values(7,5,'2022-2-2','Ram',5)
select * from orders

select * from customer
select custid from customer where city='nagpur'
select * from orders

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customer where city='nagpur')

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customer where city='bhopal')

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customer where city='indore')

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customer where city='bhopal')
order by orderdate desc
