Create Table TableNation1 (NationID Int Primary Key ,
                           NationName Varchar(500)
					    	)
Insert Into TableNation1 Values(1,'India'),
                              (2,'United-Nation'),
							  (3,'Nepal'),
							  (4,'Sri_Lanka')



Create Table TableState1 (StateID Int Primary Key,
                          NationID Int Foreign Key (NationID)
						  References TableNation1 (NationID),
						  StateName Varchar (500)
						  )
Insert Into TableState1 Values (101,1,'Andhra Pradesh'),
                               (102,1,'Punjab'),
							   (103,2,'California'),
							   (104,2,'Florida'),
							   (105,3,'Koshi'),
							   (106,3,'Bagmati'),
							   (107,4,'Colombo'),
							   (108,4,'Ratnapura')


Create Table TableCity1 (CityID Int Primary Key,
                          StateID Int Foreign Key (StateID)
						  References TableState1 (StateID),
						  CityName Varchar(500)
						  )
Insert Into TableCity1 Values (1001,101,'Visakhapatnam'),
                              (1002,101,'Vijayawada'),
							  (1003,101,'Guntur'),
							  (1004,102,'Amritsar'),
							  (1005,102,'Jalandhar'),
							  (1006,102,'Chandigarh'),
							  (1007,103,'Los Angeles'),
							  (1008,103,'San Jose'),
							  (1009,103,'San Diego'),
							  (1010,104,'Jacksonville'),
							  (1011,104,'Miami'),
							  (1012,104,'Tampa'),
							  (1013,105,'Damak'),
							  (1014,105,'Dharan'),
							  (1015,105,'Biratnagar'),
							  (1016,106,'Benepa'),
							  (1017,106,'Bharatpur'),
							  (1018,106,'Hetauda'),
							  (1019,107,'Grandpass'),
							  (1020,107,'Borella'),
							  (1021,107,'Pettah'),
							  (1022,108,'Balangoda'),
							  (1023,108,'Kolonna'),
							  (1024,108,'Panamure')


 Create Table TableCourseRegDetailes11 (CourseRegID Int Primary Key Identity,
                                      CategoryID Int,
									  FullName Varchar(1500),
									  GenderID Int)
									  
drop table TableCourseRegDetailes11
select * from TableCourseRegDetailes11

Create Table TableRegAddress12 (RegAddressID Int Primary Key ,
                               CourseRegID Int Foreign Key (CourseRegID)
							   References TableCourseRegDetailes11 (CourseRegID),
							   NationID Int Foreign Key (NationID)
							   References TableNation1 (NationID),
							   StateID Int Foreign Key (StateID)
							   References TableState1 (StateID),
							   CityID Int Foreign Key (CityID)
							   References TableCity1 (CityID)
							   )
select * from TableRegAddress12

Create Table TableFeeDetail1 (FeeID Int Primary Key,
                              CourseRegID Int Foreign Key (CourseRegID)
							   References TableCourseRegDetailes11 (CourseRegID),
							   TotalAmount Decimal,
							   MinPer Decimal,
							   PaidAmount Decimal ,
							   BalAmount Decimal,
							   PaidDate DateTime
							   )


select * from TableNation1
select * from TableState1
select * from TableCity1
select * from TableCourseRegDetailes11
select * from TableRegAddress1
select * from TableFeeDetail1
drop table TableFeeDetail1