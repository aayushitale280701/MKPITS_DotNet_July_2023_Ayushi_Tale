Create table Students (Rno INT IDENTITY PRIMARY KEY,
                       Names VARCHAR (100),
					   Addresss VARCHAR (100),
					   )

Create table Fees (FeesID INT IDENTITY PRIMARY KEY,
                   Rno INT ,
				   Amount FLOAT,
				   Dates DATE,
				   CONSTRAINT FK1 FOREIGN KEY (Rno)
				   REFERENCES Students (Rno)
				   ON UPDATE NO ACTION
				   )

insert into Students values ('Ayushi','Nagpur')
insert into Students values ('Om','Murtizapur')
insert into Students values ('Ritu','Akola')

insert into Fees values (1,20000,'2023-07-22')
insert into Fees values (2,10000,'2023-07-12')
insert into Fees values (3,15000,'2023-07-10')

update Students set Names='Aradhaya' Where Rno=1

select * from Students
select * from Fees 