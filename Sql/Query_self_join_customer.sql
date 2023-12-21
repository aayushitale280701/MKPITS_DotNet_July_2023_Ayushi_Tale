create  table Customer11( custid INT PRIMARY KEY ,
                          custname VARCHAR (50),
						  state VARCHAR (50) ,
						  city VARCHAR (50)
						 );
INSERT INTO Customer11 VALUES (1,'Avinash','MP','Bhopal')
INSERT INTO Customer11 VALUES (2,'Om','MH','Pune')
INSERT INTO Customer11 VALUES (3,'Yash','MP','Indor')
INSERT INTO Customer11 VALUES (4,'Akash','MH','Pune')
INSERT INTO Customer11 VALUES (5,'Chandu','MP','Balakhat')
INSERT INTO Customer11 VALUES (6,'Sahil','MH','Pune')

SELECT * FROM Customer11
SELECT s1.custname,s2.state,s2.city
WHERE s1.custid <> s2.custid
and s1.city = s2.city
ORDER BY city;