create table TableNation (NationID int primary key,
                          NationName varchar(500)
						  )
insert into TableNation values (11,'India')	
insert into TableNation values (12,'USA')
insert into TableNation values (13,'London')
insert into TableNation values (14,'ShreLanka')
insert into TableNation values (15,'Africa')


create table TableState (StateID int primary key ,
                         NationID int constraint fk1 foreign key (NationID)
						 references TableNation (NationID),
						 StateName varchar (500)
						 );
insert into TableState values (101,11,'Maharashtra'),
                              (102,12,'J&K'),
							  (103,13,'UP'),
							  (104,14,'MP'),
							  (105,15,'Panjab')


create table TableCity (CityID int primary key,
                        StateID int constraint fk22 foreign key (StateID)
						references TableState (StateID),
						CityName varchar (500)
						)
insert into TableCity values (1101,101,'Mumbai'),
                             (1102,102,'Lehdakh'),
							 (1103,103,'Bhopal'),
							 (1104,104,'Indor'),
							 (1105,105,'Chadighar')

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