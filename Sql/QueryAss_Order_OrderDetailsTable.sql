Create table Orders3 (OrderID INT IDENTITY PRIMARY KEY, 
                    OrderDate Date,
					CustomerID INT
					)

Create table Orders_Detailes3(OrderID INT IDENTITY PRIMARY KEY, 
                             ProductName VARCHAR(50),
							 Quantity INT,
							 CONSTRAINT FK1 FOREIGN KEY (OrderID)
							 REFERENCES Orders3 (OrderID)
							 ON UPDATE NO ACTION 
							 )

insert into Orders3 values ('2023-07-22',111)
insert into Orders3 values ('2023-08-25',112)
insert into Orders3 values ('2023-09-12',113)
insert into Orders3 values ('2023-10-05',114)
insert into Orders3 values ('2023-10-06',115)


insert into Orders_Detailes3 values ('Mouse',2)
insert into Orders_Detailes3 values ('Keyboard',5)
insert into Orders_Detailes3 values ('T.V',3)
insert into Orders_Detailes3 values ('Headphone',4)
insert into Orders_Detailes3 values ('Mobile',6)

update Orders3 set OrderID='mkpits' 
where CustomerID=113

select * from Orders_Detailes3
select * from Orders3
