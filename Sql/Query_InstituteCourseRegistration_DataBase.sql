create table TableNation1 (NationID int primary key,
                          NationName varchar(500)
						  )
insert into TableNation1 values (1,'India')	
insert into TableNation1 values (2,'United_Nation')
insert into TableNation1 values (3,'Nepal')
insert into TableNation1 values (4,'Srilanka')


create table TableState1 (StateID int primary key ,
                         NationID int foreign key (NationID)
						 references TableNation1 (NationID),
						 StateName varchar (500)
						 );
insert into TableState1 values (101,1,'Andhra Pradesh'),
                              (102,1,'Punjab'),
							  (103,2,'California'),
							  (104,2,'Florida'),
							  (105,3,'Koshi'),
							  (106,3,'Bagmati'),
							  (107,4,'Colombo'),
							  (108,4,'Ratnapura')



create table TableCity1 (CityID int primary key,
                        StateID int foreign key (StateID)
						references TableState1 (StateID),
						CityName varchar (500)
						)
insert into TableCity1 values (1001,101,'Visakhapatnam'),
                             (1002,101,'Vijayawada'),
							 (1003,101,'Guntur'),
							 (1004,102,'Amritsar'),
							 (1005,102,'Jalandhar'),
							 (1006,102,'Chandighar'),
							 (1007,103,'Los Angeles'),
							 (1008,103,'San Jose'),
							 (1009,103,'San Diego'),
							 (1010,104,'Jacksonville'),
							 (1011,104,'Miami'),
							 (1012,104,'Tampa'),
							 (1013,105,'Damak'),
							 (1014,105,'Dharan'),
							 (1015,105,'Biratnagar'),
							 (1016,106,'Banepa'),
							 (1017,106,'Bharatpur'),
							 (1018,106,'Hetauda'),
							 (1019,107,'Grandpass'),
							 (1020,107,'Borella'),
							 (1021,107,'Pettah'),
							 (1022,108,'Balangoda'),
							 (1023,108,'Kolonna'),
							 (1024,108,'Panamure')


							 
create table TableCourseRegDetail1(CourseRegID int primary key identity,
                                  CategoryID int,
								  FullName varchar(1500),
								  GenderID int
								  )



create table TableRegAddress101 (RegAddressID int primary key,
                                 CourseRegID Int foreign key (CourseRegID)
								 references TableCourseRegDetail1 (CourseRegID),
								 NationID int foreign key (NationID)
								 references TableNation1 (NationID),
								 StateID int foreign key (StateID) 
								 references TableState1 (StateID),
								 CityID int foreign key (CityID) 
								 references TableCity1 (CityID)
								 )



create table TableFeeDetail1 (FeeID int primary key,
                             CourseRegID int foreign key (CourseRegID)
							 references TableCourseRegDetail1 (CourseRegID),
							  TotalAmount decimal,
							  MinPer decimal,
							  PaidAmount decimal,
							  BalAmount decimal,
							  PaidDate datetime
							  )



select * from TableNation1
select * from TableState1
select * from TableCity1
select * from TableCourseRegDetail1
select * from TableRegAddress101
select * from TableFeeDetail1