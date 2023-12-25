create table ProductQty (Id int primary key,
                         Region varchar(25),
						 Product varchar(25),
						 Year int,
						 Quantity int,
						 Price int
						 )
insert into ProductQty values (1,'East', 'Computer', 2020,130,50000)
insert into ProductQty values (2,'South', 'Computer', 2020,450,35000)
insert into ProductQty values (3,'North', 'Computer', 2020,250,40000)
insert into ProductQty values (4,'East', 'Hard Disk', 2020,190,5500)
insert into ProductQty values (5,'West', 'Computer', 2021,250,45000)
insert into ProductQty values (6,'South', 'Hard Disk', 2021,550,4400)
insert into ProductQty values (7,'West', 'Hard Disk', 2021,650,7500)
insert into ProductQty values (8,'East', 'Pen Drive', 2021,120,800)
insert into ProductQty values (9,'North', 'Mouse', 2019,160,1500)
insert into ProductQty values (10,'South', 'Pen Drive', 2019,270,750)
insert into ProductQty values (11,'East', 'Mouse', 2019,2000,1200)
insert into ProductQty values (12,'West', 'Pen Drive', 2019,190,650)

SELECT Product , Quantity, Price
FROM ProductQty
WHERE Quantity = (SELECT MIN (Quantity) AS "Minimum Quantity"
FROM ProductQty);

SELECT Product, Quantity, Price
FROM ProductQty 
WHERE Price = (SELECT MAX (Price) AS "Minimum Quantity"
FROM ProductQty);
