create table stud1(rno int,m1 int,m2 int,m3 int)
  insert into stud1 values(1,88,87,89),(2,77,76,78)
  
  select * from stud1

  create function fun4(@m1 int,@m2 int,@m3 int)
  returns int
  as
  begin
  return (select @m1+@m2+@m3) 
  end
  
  select dbo.fun4(m1,m2,m3) as 'total marks' from stud1
