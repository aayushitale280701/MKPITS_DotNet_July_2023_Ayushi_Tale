create table fees(rno int,
                 fdate date,
				 amount int)


insert into fees values(1,'2002-2-2',1200)
insert into fees values(1,'2002-3-2',1300)
insert into fees values(1,'2002-2-4',1200)
insert into fees values(2,'2002-2-2',100)
insert into fees values(2,'2002-2-3',1200)

select * from fees
select rno,sum(amount) from fees
group by rno
