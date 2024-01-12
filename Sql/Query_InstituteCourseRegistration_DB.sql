create table TableNation1 (NationID int primary key,
                          NationName varchar(500)
						  )
insert into TableNation1 values (1,'India')	
insert into TableNation1 values (2,'United_Nation')
insert into TableNation1 values (3,'Nepal')
insert into TableNation1 values (4,'Srilanka')


create table TableState (StateID int primary key ,
                         NationID int constraint fk1 foreign key (NationID)
						 references TableNation1 (NationID),
						 StateName varchar (500)
						 );
insert into TableState values (101,1,'Andhra Pradesh'),
                              (102,1,'Punjab'),
							  (103,2,'California'),
							  (104,2,'Florida'),
							  (105,3,'Koshi'),
							  (106,3,'Bagmati'),
							  (107,4,'Colombo'),
							  (108,4,'Ratnapura')


create table TableCity (CityID int primary key,
                        StateID int constraint fk22 foreign key (StateID)
						references TableState (StateID),
						CityName varchar (500)
						)
insert into TableCity values (1001,101,'Visakhapatnam'),
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
							 


create table TableCourseRegDetail(CourseRegID int primary key,
                                  CategoryID int,
								  FullName varchar(1500),
								  GenderID int
								  )
insert into TableCourseRegDetail values (21,201,'Ayushi',1),
                                        (22,202,'Prachi',2),
										(23,203,'Priya',3),
										(24,204,'Mayuri',4),
										(25,205,'Pooja',5)


create table TableRegAddress (RegAddressID int primary key,
                              CourseRegID int constraint fk111 foreign key (CourseRegID)
							  references TableCourseRegDetail (CourseRegID),
							  NationID int constraint fk222 foreign key (NationID)
						      references TableNation (NationID),
							  StateID int constraint fk333 foreign key (StateID)
						      references TableState (StateID),
							  CityId int constraint fk444 foreign key (CityID)
							  references TableCity (CityID)
							  )
insert into TableRegAddress values (501,21,11,101,1101),
                                   (502,22,12,102,1102),
								   (503,23,13,103,1103),
								   (504,24,14,104,1104),
								   (505,25,15,105,1105)

create table TableFeeDetail (FeeID int primary key,
                             CourseRegID int constraint fk33 foreign key (CourseRegID)
							 references TableCourseRegDetail (CourseRegID),
							  TotalAmount decimal,
							  MinPer decimal,
							  PaidAmount decimal,
							  BalAmount decimal,
							  PaidDate datetime
							  )
insert into TableFeeDetail values (301,21,20000.00,401,15000.00,10000.00,'2023/10/12'),
                                  (302,22,30000.00,402,20000.00,8000.00,'2023/12/01'),
								  (303,23,40000.00,403,25000.00,9000.00,'2023/12/21'),
								  (304,24,50000.00,404,30000.00,11000.00,'2023/12/30'),
								  (305,25,60000.00,405,35000.00,12000.00,'2023/12/29')


select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail