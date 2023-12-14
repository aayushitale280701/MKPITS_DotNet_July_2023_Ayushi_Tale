Create table Product(P_ID bigint,P_Name varchar(20),P_Category_ID bigint,Model_Year int, List_Price bigint)
insert into Product values(121,'Mouse',11,2009,500)
insert into Product values(122,'Keyboard',13,2015,600)
insert into Product values(123,'CPU',45,2012,2000)
insert into Product values(124,'Headphones',42,2021,1500)
select * from Product Where P_Category_ID=13 order by List_Price desc