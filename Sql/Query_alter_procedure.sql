SELECT * FROM Products221

SELECT  product_name,list_price
FROM Products221
ORDER BY product_name
--------------------------------------
create proc prod11
as
begin
SELECT * FROM Products221
end;
exec prod11
---------------------------------------
create proc mprod1
as
begin
SELECT * FROM Products221 where model_year=2022
end;
exec mprod1
----------------------------------------
create proc prod3(@minprice as decimal)
as
begin
select * from Products221
where list_price > @minprice
order by list_price
end;
exec prod3 900
exec prod3 1000
-----------------------------------------
create proc proddet2 (@Pid as int)
as 
begin
select * from Products221
where Product_id  < @Pid
end;
exec proddet2 4
----------------------------------------
create proc pp2 (@pname as varchar (20))
as 
begin
select * from Products221
where Product_Name = @pname
end;
exec pp2 'Front Wheel'
------------------------------------------
--stored proc with 2 parameters
create proc Prod77 (@pname as varchar (20), @p as decimal)
as
begin
select * from Products221
where Product_Name = @pname
and list_price >= @pname
order by Product_Name
end;
exec Prod77 'Back Wheel'
exec Prod77 'Front Wheel'
------------------------------------------
create proc prod8(@minp as decimal,@maxp as decimal)
as
begin
select * from Products221
where list_price > @minp and list_price < @maxp
order by Product_Name
end;
exec prod8 900,2000
-------------------------------------------
create proc prod9(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from Products221
where list_price > @minp and list_price < @maxp
and Product_Name LIKE '%' + @pn + '%'

order by Product_Name
end;

exec prod9 @minp=120,@maxp=500,@pn='Wheel'
exec prod9 @minp=120,@maxp=500,@pn='oil'
---------------------------------------------
create proc prod10(@minp as decimal=100,@maxp as decimal=1000,@pn as varchar(max))
as
begin
select * from Products221
where list_price > @minp and list_price < @maxp
and Product_Name LIKE '%' + @pn + '%'
order by Product_Name
end;

exec prod10 @minp=120,@maxp=500,@pn='wheel'
exec prod10 @minp=230,@pn='oil'
------------------------------------------------
create proc prod12(@minp as decimal=100,@maxp as decimal=null,@pn as varchar(max))
as
begin
select * from Products221
where
list_price >= @minp AND
        (@maxp IS NULL OR list_price <= @maxp) AND
        product_name LIKE '%' + @pn + '%'
end;

exec prod12 120,200,'Wheel'
exec prod12 120,200,'oil'
exec prod12 @minp=100,@pn='e'

-----------insert query-------------------- 
create proc sp_inprod11
as 
begin
insert into Products221 values(5,'Mirror',155,145,2020,1500);
end

exec sp_inprod11
select * from Products221

