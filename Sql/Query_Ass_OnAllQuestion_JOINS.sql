create table Departments11 (DEPARTMENT_ID int,
                          DEPARTMENT_NAME varchar(50),
						  MANAGER_ID int,
                          LOCATION_ID int );

insert into Departments11 values (10 ,' Administration',200,1700)
insert into Departments11 values (20 ,' Marketing',201,1800)
insert into Departments11 values (30 ,' Purchasing',114,1700)
insert into Departments11 values (40 ,' Human Resources',203,2400)
insert into Departments11 values (50 ,' Shipping',121,1500 )
insert into Departments11 values (60 ,' IT',103,1400)
insert into Departments11 values (70 ,' Public Relations',204,2700)
insert into Departments11 values (80 ,' Sales',145,2500)
insert into Departments11 values (90 ,' Executive',100,1700)
insert into Departments11 values (100 ,' Finance',108,1700)
insert into Departments11 values (110 ,' Accounting',205,1700)
insert into Departments11 values (120 ,' Treasury', 0,1700)
insert into Departments11 values (130 ,' Corporate Tax',0,1700)
insert into Departments11 values (140 ,' Control And Credit',0,1700)
insert into Departments11 values (150 ,' Shareholder Services ',0,1700)
insert into Departments11 values (160 ,' Benefits',0,1700)
insert into Departments11 values (170 ,' Manufacturing',0,1700)
insert into Departments11 values (180 ,' Construction',0,1700)
insert into Departments11 values (190 ,' Contracting',0,1700)
insert into Departments11 values (200 ,' Operations',0,1700)
insert into Departments11 values (210 ,' IT Support',0,1700)
insert into Departments11 values (220 ,' NOC ',0,1700)
insert into Departments11 values (230 ,' IT Helpdesk ',0,1700)
insert into Departments11 values (240 ,' Government Sales',0,1700)
insert into Departments11 values (250 ,' Retail Sales',0,1700)
insert into Departments11 values (260 ,' Recruiting', 0,1700)
insert into Departments11 values (270 ,' Payroll',0,1700)
SELECT * FROM Departments11

create table Employees11 (EMPLOYEE_ID int,
                        FIRST_NAME  varchar(50),
						LAST_NAME  varchar(50), 
						EMAIL varchar(50),
						PHONE_NUMBER bigint,
						HIRE_DATE date ,
						JOB_ID varchar(50),
						SALARY float,
						COMMISSION_PCT float,
						MANAGER_ID int,
						DEPARTMENT_ID int
						)

insert into Employees11 values (100,'Steven','King','SKING',5151234567,'2003-06-17','AD_PRES',24000.00,0.00,0,90)
insert into Employees11 values (101,'Neena','Kochhar','NKOCHHAR',5151234568,'2005-09-21','AD_VP',17000.00,0.00,100,90)
insert into Employees11 values (102,'Lex','De Haan','LDEHAAN',5151234569,'2001-01-13','AD_VP',17000.00,0.00,100,90)
insert into Employees11 values (103,'Alexander','Hunold','AHUNOLD ',5904234567,'2006-01-03','IT_PROG',9000.00,0.00,102,60)
insert into Employees11 values (104,'Bruce','Ernst','BERNST',5904234568,'2007-05-21','IT_PROG',6000.00,0.00,103,60)
insert into Employees11 values (105,'David','Austin','DAUSTIN',5904234569,'2005-06-25',' IT_PROG',4800.00,0.00,103,60)
insert into Employees11 values (106,'Valli','Pataballa','VPATABAL',5904234560,'2006-02-05','IT_PROG',4800.00,0.00,103,60)
insert into Employees11 values (107,'Diana','Lorentz','DLORENTZ',5904235567,'2007-02-07','IT_PROG',4200.00,0.00,103,60)
insert into Employees11 values (108,'Nancy','Greenberg','NGREENBE',5151244569,'2002-08-17','FI_MGR',12008.00,0.00 ,101,100)
insert into Employees11 values (109,'Daniel','Faviet','DFAVIET',5151244169,'2002-08-16','FI_ACCOUNT',9000.00,0.00,108,100)
insert into Employees11 values (110,'John','Chen','JCHEN',5151244269,'2005-09-28','FI_ACCOUNT',8200.00, 0.00,108,100)
insert into Employees11 values (111,'Ismael','Sciarra','ISCIARRA',5151244369,'2005-09-30','FI_ACCOUNT',7700.00,0.00,108,100)
insert into Employees11 values (112,'Jose Manuel','Urman','JMURMAN',5151244469,'2006-03-07','FI_ACCOUNT',800.00,0.00,108,100)
insert into Employees11 values (113,'Luis','Popp','LPOPP',5151244567,'2007-12-07','FI_ACCOUNT',6900.00,0.00,108,100)
insert into Employees11 values (114,'Den','Raphaely','DRAPHEAL',5151274561,'2002-12-07','PU_MAN',11000.00,0.00,100,30)
insert into Employees11 values (115,'Alexander','Khoo','AKHOO',5151274562,'2003-05-18','PU_CLERK',3100.00,0.00,114,30)
insert into Employees11 values (116,'Shelli','Baida','SBAIDA',5151274563,'2005-12-24','PU_CLERK',2900.00, 0.00,114,30)
insert into Employees11 values (117,'Sigal','Tobias','STOBIAS',5151274564,'2005-07-24','PU_CLERK',2800.00,0.00,114,30)
insert into Employees11 values (118,'Guy','Himuro','GHIMURO',5151274565,'2006-11-15','PU_CLERK',2600.00,0.00,114,30)
insert into Employees11 values (119,'Karen','Colmenares','KCOLMENA',5151274566,'2007-08-10','PU_CLERK',2500.00,0.00,114,30)
insert into Employees11 values (120,'Matthew','Weiss','MWEISS',6501231234,'2004-07-18','ST_MAN',8000.00,0.00,100,50)
insert into Employees11 values (121,'Adam','Fripp','AFRIPP',6501232234,'2005-04-10','ST_MAN',8200.00,0.00,100,50)
insert into Employees11 values (122,'Payam','Kaufling','PKAUFLIN',6501233234,'2003-05-01','ST_MAN',7900.00,0.00,100,50)
insert into Employees11 values (123,'Shanta','Vollman','SVOLLMAN',6501234234,'2005-10-10','ST_MAN',6500.00,0.00,100,50)
insert into Employees11 values (124,'Kevin','Mourgos','KMOURGOS',6501235234,'2007-11-16','ST_MAN',5800.00,0.00,100,50)
insert into Employees11 values (125,'Julia','Nayer','JNAYER',6501241214,'2005-07-16','ST_CLERK',3200.00,0.00,120,0)
insert into Employees11 values (126,'Irene','Mikkilineni','IMIKKILI',6501241224,'2006-09-28','ST_CLERK',2700.00,0.00,120,50)
insert into Employees11 values (127,'James','Landry','JLANDRY',6501241334,'2007-01-14','ST_CLERK ',2400.00,0.00,120,50)
insert into Employees11 values (128,'Steven','Markle','SMARKLE',6501241434,'2008-03-08',' ST_CLERK',2200.00,0.00,120,50)
insert into Employees11 values (129,'Laura','Bissot','LBISSOT',6501245234,'2005-08-20','ST_CLERK',3300.00,0.00,121,50)
insert into Employees11 values (130,'Mozhe','Atkinson','MATKINSO',6501246234,'2005-10-30','ST_CLERK',2800.00,0.00,121,50)
insert into Employees11 values (131,'James','Marlow','JAMRLOW',6501247234,'2005-02-16','ST_CLERK',2500.00,0.00,121,50)
insert into Employees11 values (132,'TJ','Olson','TJOLSON',6501248234,'2007-04-10','ST_CLERK',2100.00,0.00,121,50)
insert into Employees11 values (133,'Jason','Mallin','JMALLIN',6501271934,'2004-06-14','ST_CLERK',3300.00,0.00,122,50)
insert into Employees11 values (134,'Michael','Rogers','MROGERS',6501271834,'2006-08-26','ST_CLERK',2900.00,0.00,122,50)
insert into Employees11 values (135,'Ki','Gee','KGEE',6501271734,'2007-12-12','ST_CLERK',2400.00 ,0.00 ,122 ,50)
insert into Employees11 values (136,'Hazel','Philtanker','HPHILTAN',6501271634,'2008-02-06','ST_CLERK',2200.00,0.00,122 ,50)
insert into Employees11 values (137,'Renske','Ladwig','RLADWIG',6501211234,'2003-07-14','ST_CLERK',3600.00,0.00,123,50)
insert into Employees11 values (138,'Stephen','Stiles','SSTILES',6501212034,'2005-10-26','ST_CLERK',3200.00,0.00 ,123 ,50 )
insert into Employees11 values (139,'John','Seo','JSEO',6501212019,'2006-02-12','ST_CLERK',2700.00,0.00,123,50)
insert into Employees11 values (140,'Trenna','Rajs','TRAJS',6501218009,'2003-10-17','ST_CLERK',3500.00,0.00, 124,50)
insert into Employees11 values (142,'Curtis','Davies','CDAVIES',6501212994,'2005-01-29','ST_CLERK',3100.00,0.00 ,124,50)
insert into Employees11 values (143,'Randall','Matos','RMATOS',6501212874,'2006-03-15','ST_CLERK',2600.00,0.00,124 ,50 )
insert into Employees11 values (144,'Peter','Vargas','PVARGAS',6501212004,'2006-07-09','ST_CLERK',2500.00,0.00 ,124,50 )
insert into Employees11 values (145,'John','Russell','JRUSSEL',011441344429268,'2004-10-01','SA_MAN',14000.00,0.40,100,80 )
insert into Employees11 values (146,'Karen','Partners','KPARTNER',011441344467268,'2005-01-05','SA_MAN',13500.00,0.30 ,100 ,80 )
insert into Employees11 values (147,'Alberto','Errazuriz','AERRAZUR',011441344429278,'2005-03-10','SA_MAN',12000.00,0.30,100,80 )
insert into Employees11 values (148,'Gerald','Cambrault','GCAMBRAU',011441344619268,'2007-10-15','SA_MAN',11000.00,0.30,100,80 )
insert into Employees11 values (149,'Eleni','Zlotkey','EZLOTKEY',011441344429018,'2008-01-29','SA_MAN',10500.00,0.20,100,80 )
insert into Employees11 values (150,'Peter','Tucker','PTUCKER',011441344129268,'2005-01-30','SA_REP',10000.00,0.30,145,80 )
insert into Employees11 values (151,'David','Bernstein','DBERNSTE',011441344345268,'2005-03-24','SA_REP',9500.00,0.25,145,80 )
insert into Employees11 values (152,'Peter','Hall','PHALL',011441344478968,'2005-08-20','SA_REP',9000.00,0.25,145,80 )
insert into Employees11 values (153,'Christopher','Olsen','COLSEN',011441344498718,'2006-03-30','SA_REP',8000.00,0.20,145,80)
insert into Employees11 values (154,'Nanette','Cambrault','NCAMBRAU',011441344987668,'2006-12-09','SA_REP',7500.00,0.20,145,80 )
insert into Employees11 values (155,'Oliver','Tuvault','OTUVAULT',011441344486508,'2007-11-23','SA_REP',7000.00,0.15,145,80 )
insert into Employees11 values (156,'Janette','King','JKING',011441345429268,'2004-01-30','SA_REP',10000.00,0.35 ,146 ,80 )
insert into Employees11 values (157,'Patrick','Sully','PSULLY',011441345929268,'2004-03-04','SA_REP',9500.00,0.35,146, 80 )
insert into Employees11 values (158,'Allan','McEwen','AMCEWEN',011441345829268,'2004-08-01','SA_REP',9000.00 ,0.35, 146,80 )
insert into Employees11 values (159,'Lindsey','Smith','LSMITH',011441345729268,'2005-03-10','SA_REP',8000.00,0.30 ,146,80 )
insert into Employees11 values (160,'Louise','Doran','LDORAN',011441345629268,'2005-12-15','SA_REP',7500.00,0.30,146 ,80)
insert into Employees11 values (161,'Sarath','Sewall','SSEWALL',011441345529268,'2006-11-03','SA_REP',7000.00,0.25,146,80)
insert into Employees11 values (162,'Clara','Vishney','CVISHNEY',011441346129268,'2005-11-11','SA_REP',10500.00,0.25,147,80)
insert into Employees11 values (163,'Danielle','Greene','DGREENE',011441346229268,'2007-03-19','SA_REP',9500.00,0.15 ,147,80 )
insert into Employees11 values (164,'Mattea','Marvins','MMARVINS',011441346329268,'2008-01-24','SA_REP',7200.00,0.10,147,80 )
insert into Employees11 values (165,'David','Lee','DLEE',011441346529268,'2008-02-23','SA_REP',6800.00,0.10,147,80 )
insert into Employees11 values (166,'Sundar','Ande','SANDE',011441346629268,'2008-03-24','SA_REP',6400.00,0.10,147 ,80 )
insert into Employees11 values (167,'Amit','Banda','ABANDA',011441346729268,'2008-04-21','SA_REP',6200.00,0.10,147 ,80)
insert into Employees11 values (168,'Lisa','Ozer','LOZER',011441343929268,'2005-03-11','SA_REP',11500.00,0.25,148 ,80 )
insert into Employees11 values (169,'Harrison','Bloom','HBLOOM',011441343829268,'2006-03-23','SA_REP',10000.00 ,0.20,148,80)
insert into Employees11 values (170,'Tayler','Fox','TFOX',011441343729268,'2006-01-24','SA_REP',9600.00,0.20,148,80 )
insert into Employees11 values (171,'William','Smith','WSMITH',011441343629268,'2007-02-23','SA_REP',7400.00,0.15,148,80 )
insert into Employees11 values (172,'Elizabeth','Bates','EBATES',011441343529268,'2007-03-24','SA_REP',7300.00,0.15,148 ,80 )
insert into Employees11 values (173,'Sundita','Kumar','SKUMAR',011441343329268,'2008-04-21','SA_REP',6100.00,0.10 ,148,80)
insert into Employees11 values (174,'Ellen','Abel','EABEL',011441644429267,'2004-05-11','SA_REP',11000.00 ,0.30,149,80 )
insert into Employees11 values (175,'Alyssa','Hutton','AHUTTON',011441644429266,'2005-03-19','SA_REP',8800.00,0.25,149 ,80 )
insert into Employees11 values (176,'Jonathon','Taylor','JTAYLOR',011441644429265,'2006-03-24','SA_REP',8600.00,0.20,149,80 )
insert into Employees11 values (177,'Jack','Livingston','JLIVINGS',011441644429264,'2006-04-23','SA_REP',8400.00,0.20 ,149,80 )
insert into Employees11 values (178,'Kimberely','Grant','KGRANT',011441644429263,'2007-05-24','SA_REP',7000.00,0.15 ,149, 0)
insert into Employees11 values (179,'Charles','Johnson','CJOHNSON',011441644429262,'2008-01-04','SA_REP',6200.00,0.10,149,80 )
insert into Employees11 values (180,'Winstonv','Taylor','WTAYLOR',6505079876,'2006-01-24','SH_CLERK',3200.00,0.00 ,120 ,50 )
insert into Employees11 values (181,'Jean','Fleaur','JFLEAUR',6505079877,'2006-02-23','SH_CLERK',3100.00,0.00,120 ,50 )
insert into Employees11 values (182,'Martha','Sullivan','MSULLIVA',6505079878,'2007-06-21','SH_CLERK',2500.00,0.00,120,50 )
insert into Employees11 values (183,'Girard','Geoni','GGEONI',6505079879,'2008-02-03','SH_CLERK',2800.00 ,0.00 , 120,50 )
insert into Employees11 values (184,'Nandita','Sarchand','NSARCHAN',6505091876,'2004-01-27','SH_CLERK',4200.00,0.00 ,121,50 )
insert into Employees11 values (185,'Alexis ','Bull','ABULL',6505092876,'2005-02-20','SH_CLERK',4100.00,0.00,121 ,50 )
insert into Employees11 values (186,'Julia','Dellinger','JDELLING',6505093876,'2006-06-24','SH_CLERK',3400.00,0.00,121,50 )
insert into Employees11 values (187,'Anthony','Cabrio','ACABRIO',6505094876,'2007-02-07','SH_CLERK',3000.00,0.00,121,50 )
insert into Employees11 values (188,'Kelly','Chung','KCHUNG',6505051876,'2005-06-14','SH_CLERK',3800.00,0.00,122 , 50 )
insert into Employees11 values (189,'Jennifer','Dilly','JDILLY',6505052876,'2005-08-13','SH_CLERK',3600.00, 0.00,122 ,50 )
insert into Employees11 values (190,'Timothy','Gates','TGATES',6505053876,'2006-07-11','SH_CLERK',2900.00 ,0.00 ,122, 50 )
insert into Employees11 values (191,'Randall','Perkins','RPERKINS',505054876,'2007-12-19','SH_CLERK',2500.00,0.00,122,50 )
insert into Employees11 values (192,'Sarah','Bell','SBELL',6505011876,'2004-02-04','SH_CLERK',4000.00 , 0.00 ,123,50 )
insert into Employees11 values (193,'Britney','Everett','BEVERETT',6505012876,'2005-03-03','SH_CLERK',3900.00,0.00 ,123,50 )
insert into Employees11 values (194,'Samuel','McCain','SMCCAIN',6505013876,'2006-07-01','SH_CLERK',3200.00,0.00 ,123,50 )
insert into Employees11 values (195,'Vance','Jones','VJONES',6505014876,'2007-03-17','SH_CLERK',2800.00,0.00,124,50 )
insert into Employees11 values (197,'Kevin','Feeney','KFEENEY',6505079822,'2006-05-23','SH_CLERK',3000.00,0.00,124, 50 )
insert into Employees11 values (198,'Donald','OConnell','DOCONNEL',6505079833,'2007-06-21','SH_CLERK',2600.00,0.00,124,50 )
insert into Employees11 values (199,'Douglas','Grants','DGRANT',6505079844,'2008-01-13','SH_CLERK',2600.00, 0.00 ,124, 50 )
insert into Employees11 values (200,'Jennifer','Whalen','JWHALEN',5151234444,'2003-09-17','D_ASST ',4400.00 ,0.00 ,101 , 10 )
insert into Employees11 values (201,'Michael','Hartstein','MHARTSTE',5151235555,'2004-02-17','MK_MAN',13000.00 , 0.00 , 100 ,20 )
insert into Employees11 values (202,'Pat','Fay','PFAY',6031236666,'2005-08-17','MK_REP',6000.00,0.00,201,20)
insert into Employees11 values (203,'Susan','Mavris','SMAVRIS',5151237777,'2002-06-07','HR_REP ',6500.00,0.00 ,101,40 )
insert into Employees11 values (204,'Hermann','Baer','HBAER',5151238888,'2002-06-07','PR_REP',10000.00,0.00,101,70 )
insert into Employees11 values (205,'Shelley','Higgins','SHIGGINS',5151238080,'2002-06-07','AC_MGR',12008.00,0.00,101,110)
insert into Employees11 values (206,'William','Gietz','WGIETZ',5151238181,'2002-06-07','AC_ACCOUNT',8300.00,0.00,205,110)

select * from Employees11

create table Locations11 (LOCATION_ID int,
                          STREET_ADDRESS varchar(50),
						  POSTAL_CODE varchar(50),
						  CITY varchar(50),
						  STATE_PROVINCE varchar (50),
						  COUNTRY_ID varchar(50)
						  )

insert into Locations11 values (1000,'1297 Via Cola di Rie','989' ,'Roma','           ','IT')
insert into Locations11 values (1100,'93091 Calle della Testa','10934','Venice','              ','IT ')
insert into Locations11 values (1200,'2017 Shinjuku-ku','1689','Tokyo','Tokyo Prefecture','JP')
insert into Locations11 values (1300,'9450 Kamiya-cho','6823','Hiroshima','           ','JP')
insert into Locations11 values (1400,'2014 Jabberwocky Rd','26192','Southlake','Texas','US')
insert into Locations11 values (1500,'2011 Interiors Blvd','99236','South San Francisco','California','US ')
insert into Locations11 values (1600,'2007 Zagora St','50090','South Brunswick','New Jersey','US')
insert into Locations11 values (1700,'2004 Charade Rd','98199','Seattle','Washington','US')
insert into Locations11 values (1800,'147 Spadina Ave','M5V 2L7','Toronto','Ontario','CA')
insert into Locations11 values (1900,'6092 Boxwood St','YSW 9T2','Whitehorse','Yukon ','CA ')
insert into Locations11 values (2000,'40-5-12 Laogianggen','190518','Beijing ','           ','CN ')
insert into Locations11 values (2100,'1298 Vileparle (E)','490231','Bombay','Maharashtra','IN ')
insert into Locations11 values (2200,'12-98 Victoria Street','2901','Sydney','New South Wales','AU ')
insert into Locations11 values (2300,'198 Clementi North','540198','Singapore','           ','SG ')
insert into Locations11 values (2400,'8204 Arthur St','           ','London','           ','UK')
insert into Locations11 values (2500,'Magdalen Centre, The Oxford Science Park','OX9 9ZB','Oxford','Oxford','UK')
insert into Locations11 values (2600,'9702 Chester Road','9629850293','Stretford ','Manchester','UK')
insert into Locations11 values (2700,'Schwanthalerstr.7031','80925','Munich','Bavaria ','DE ')
insert into Locations11 values (2800,'Rua Frei Caneca.1360','01307-00','Sao Paulo','Sao Paulo',' BR')
insert into Locations11 values (2900,'20 Rue des Corps-Saints','1730 ','Geneva','Geneve',' CH')
insert into Locations11 values (3000,'Murtenstrasse 921','3095','Bern','BE','CH ')
insert into Locations11 values (3100,'Pieter Breughelstraat 837','3029SK','Utrecht','Utrecht','NL')
insert into Locations11 values (3200,'Mariano Escobedo 9991','11932','Mexico City','Distrito Federal','MX ')

SELECT * FROM Locations11

create table Job_Grades (GRADE_LEVEL varchar(50),
                         LOWEST_SAL varchar(50),
						 HIGHEST_SAL varchar(50)
						 )

insert into Job_Grades values ('A','1000','2999')
insert into Job_Grades values ('B','3000','5999')
insert into Job_Grades values ('C','6000','9999')
insert into Job_Grades values ('D','10000','14999')
insert into Job_Grades values ('E','15000','24999')
insert into Job_Grades values ('F','25000','40000')

select * from Job_Grades


--Q1
SELECT E.FIRST_NAME, E.LAST_NAME,E.DEPARTMENT_ID,D.DEPARTMENT_NAME
FROM Employees11 E
JOIN Departments11 D
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID;

--Q2
SELECT E.FIRST_NAME,E.LAST_NAME,D.DEPARTMENT_NAME, L.CITY, L.STATE_PROVINCE
FROM Employees11 E 
JOIN Departments11 D  
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID  
JOIN Locations11 L
ON D.LOCATION_ID = L.LOCATION_ID;

--Q3
SELECT E.FIRST_NAME, E.LAST_NAME, E.SALARY, J.GRADE_LEVEL
FROM Employees11 E 
JOIN Job_Grades J
ON E.SALARY BETWEEN J.LOWEST_SAL AND J.HIGHEST_SAL;

--Q4
SELECT E.FIRST_NAME , E.LAST_NAME , E.DEPARTMENT_ID ,  D.DEPARTMENT_NAME
FROM Employees11 E 
JOIN Departments11 D 
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID 
AND E.DEPARTMENT_ID IN (80 , 40)
ORDER BY E.LAST_NAME;

--Q5
SELECT E.FIRST_NAME,E.LAST_NAME,D.DEPARTMENT_NAME, L.CITY, L.STATE_PROVINCE
FROM Employees11 E 
JOIN Departments11 D  
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID 
JOIN Locations11 L 
ON D.LOCATION_ID = L.LOCATION_ID 
WHERE E.FIRST_NAME LIKE  '%z%';

--Q6
SELECT E.FIRST_NAME, E.LAST_NAME, D.DEPARTMENT_ID, D.DEPARTMENT_NAME 
FROM Employees11 E 
RIGHT OUTER JOIN Departments11 D
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID;

--Q7
SELECT E.FIRST_NAME, E.LAST_NAME, E.SALARY 
FROM Employees11 E 
JOIN Employees11 S
ON E.SALARY < S.SALARY 
AND S.EMPLOYEE_ID = 182;

--Q8
SELECT E.FIRST_NAME AS "Employee Name", M.FIRST_NAME AS "Manager"
FROM Employees11 E 
JOIN Employees11 M
ON E.MANAGER_ID = M.MANAGER_ID;

--Q9
SELECT D.DEPARTMENT_NAME , L.CITY , L.STATE_PROVINCE
FROM  Departments11 D 
JOIN Locations11 L 
ON  D.LOCATION_ID = L.LOCATION_ID;

--Q10
SELECT E.FIRST_NAME, E.LAST_NAME, E.DEPARTMENT_ID, D.DEPARTMENT_NAME 
FROM Employees11 E 
LEFT OUTER JOIN Departments11 D 
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID;

--Q11
SELECT E.FIRST_NAME AS "Employee Name", M.FIRST_NAME AS "Manager"
FROM Employees11 E 
LEFT OUTER JOIN Employees11 M
ON E.MANAGER_ID = M.EMPLOYEE_ID;

--Q12
SELECT E.FIRST_NAME, E.LAST_NAME, E.DEPARTMENT_ID 
FROM Employees11 E 
JOIN Employees11 S
ON E.DEPARTMENT_ID = S.DEPARTMENT_ID
AND S.LAST_NAME = 'Taylor';
