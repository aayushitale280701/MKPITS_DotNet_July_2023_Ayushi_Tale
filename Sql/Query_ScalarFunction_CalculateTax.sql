create table incometax (a1 int, a2 int, a3 int)
insert into incometax values (111,11,10)
insert into incometax values (222,22,20)
insert into incometax values (333,33,30)
insert into incometax values (444,44,40)
insert into incometax values (555,55,50)
insert into incometax values (666,66,60)
SELECT * FROM incometax

create function CalculatedTax (@a1 int, @a2 int, @a3 int)
returns int 
as begin
return (select @a1  + @a2  + @a3  )
end;
select  dbo.calculatedtax(a1,a2,a3) as 'Total tax' from incometax

drop table incometax
drop function calculatedtax