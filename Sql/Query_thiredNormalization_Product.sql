create table Product11( OrderId int primary key,
                        ProductId int ,
						Rate int,
						Quentity int
						);
insert into Product11 values (1,1001,100,2), 
                              (2,1002,200,3),
							  (3,1003,300,2)



create table ProductDetailes(CustId int primary key,
                             City varchar (50),
							 State varchar (50),
							 OrderId int constraint fk1 foreign key (OrderId)
							 references Product11 (OrderId),
							 OrderDate datetime
							 )
insert into ProductDetailes values (101,'Ngp','MH',1,12/12/2023)
insert into ProductDetailes values (102,'Mzr','MH',2,13/10/2022)
insert into ProductDetailes values (103,'Ngp','MH',3,14/11/2021)


create table ProductRate(ProductId int primary key,
                         Rate int)
insert into ProductRate values (111,500),
                               (112,600),
							   (113,550)


select * from Product11
select * from ProductDetailes 
select * from ProductRate

