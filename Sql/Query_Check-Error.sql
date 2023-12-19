CREATE TABLE Product2(ProductID INT IDENTITY PRIMARY KEY,
                      ProductName VARCHAR (250) NOT NULL,
					  UnitPrice DEC(10,2) CHECK (UnitPrice >0))

Insert into Product2 values ('Mouse',122)
Insert into Product2 values ('Keyboard',0)
Select * from Product2
--Error--

CREATE TABLE Result (Rno INT IDENTITY PRIMARY KEY,
                     Marks DEC(10,2) CHECK (Marks > 0))

insert into Result values (11,500)
insert into Result values (1,0)

Select * from Result
--Error--