select * from Student11
---------------------------
--Q1
create proc std1
as
begin
select * from Student11
end;
exec std1
-----------------------------
--Q2
create proc std2
as
begin
select * from Student11 
where city='Nagpur'
end;
exec std2
-------------------------------
--Q3
create proc std3 
as
begin
select * from Student11
where StdRollNo>13 AND StdRollNo<20
end; 
exec std3
--------------------------------------
--Q9
create proc std5 (@r_no as int)
as
begin
select * from Student11 
where StdRollNo = @r_no
end;
exec std5 15
--drop proc std5
---------------------------------------
--Q10
create proc std6 (@rno as int , @sname as varchar (20))
as 
begin
select * from Student11
where StdRollNo = @rno and StdName = @sname
end;
exec std6 @rno=16, @sname='Ayush'
exec std6 @rno=18, @sname='Rita'
exec std6 @rno=19, @sname='Prachi'
drop proc std6
