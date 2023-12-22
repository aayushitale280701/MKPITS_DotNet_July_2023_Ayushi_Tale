create table sample12345(id int identity primary key,
                        name varchar(20))

insert into sample12345 values('mouse')
insert into sample12345 values('keyboard')
select * from sample12345

delete from sample12345
select * from sample12345

insert into sample12345 values('mouse')
insert into sample12345 values('keyboard')
select * from sample12345
--truncate will delete the record and when you
--insert new records it will start from one
truncate table sample12345
select * from sample12345
insert into sample12345 values('mouse')
insert into sample12345 values('keyboard')
select * from sample12345

--adding one more column to existing table
alter table sample12345
add price int

--sp_help sample12345
--query to change datatype of column
alter table sample12345
alter column price dec(10,2)

--query to drop column
alter table sample12345
drop column price

--sp_rename 'sample12345', 'newsample'

