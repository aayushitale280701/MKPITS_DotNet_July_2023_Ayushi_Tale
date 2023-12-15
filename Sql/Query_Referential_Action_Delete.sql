
-----Orders----

Create table Orders (OrderID int PRIMARY KEY, 
                    OrderDate Date,
					CustomerID int
					)

Create table Orders_Detailes(OrderID int, 
                             ProductName varchar(50),
							 Quantity int,
							 CONSTRAINT FK1 FOREIGN KEY (OrderID)
							 REFERENCES Orders (OrderID)
							 )

insert into Orders values (1,'2023-07-22',111)
insert into Orders values (2,'2023-08-25',112)
insert into Orders values (3,'2023-09-12',113)
insert into Orders values (4,'2023-10-05',114)
select * from Orders

insert into Orders_Detailes values (1,'Mouse',2)
insert into Orders_Detailes values (1,'Keyboard',5)
insert into Orders_Detailes values (1,'T.V',3)
insert into Orders_Detailes values (2,'Headphone',4)
insert into Orders_Detailes values (2,'T.V',1)
insert into Orders_Detailes values (3,'Mobile',6)
select * from Orders_Detailes

delete from Orders_Detailes where OrderID=1
insert into Orders_Detailes values(2,'2022-09-07',2)
select * from Orders_Detailes
