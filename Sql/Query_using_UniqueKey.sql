CREATE TABLE Employee1 (ID INT UNIQUE,
                        Names VARCHAR (20),
						)

INSERT INTO Employee1 VALUES (1,'Ayushi')
INSERT INTO Employee1 VALUES (2,'Ritu')
INSERT INTO Employee1 VALUES (3,'Ayush')
INSERT INTO Employee1 VALUES (4,'Rajesh')

CREATE TABLE Employee2 (EmpID INT PRIMARY KEY,
                        Empname VARCHAR (20),
						PassprotNo INT,
						DrivingLicenceNo INT,
						CONSTRAINT E1
						UNIQUE (PassprotNo, DrivingLicenceNo)
						)

INSERT INTO Employee2  VALUES (1,'Ayushi',23456,4586)
INSERT INTO Employee2 VALUES (2,'Rajesh', 45678,9512)
INSERT INTO Employee2 VALUES (3,'Aradhaya',65923,9876)
INSERT INTO Employee2 VALUES (4,'Ritu',45623,3216)

CREATE TABLE Employee3 (EmpID INT PRIMARY KEY,
                        Emp_Name VARCHAR (20),
						Pno INT UNIQUE ,
						DLNo INT UNIQUE
						)

INSERT INTO Employee3 VALUES (1,'Ayushi',111,222)
INSERT INTO Employee3 VALUES (2,'Ayushi',112,223)


SELECT * FROM Employee1
SELECT * FROM Employee2
SELECT * FROM Employee3

