create table incometax(m1 int ,m2 int, m3 int)

insert into incometax values(123,234,456),
                             (654,321,123),
							 (987,654,356)

							 select * from incometax

create function CalculateTax(@m1 int ,@m2 int ,@m3 int )
returns int 
as begin
return (select @m1 + @m2 + @m3 )
end

select dbo.CalculateTax (m1,m2,m3) as 'Total Tax'from incometax