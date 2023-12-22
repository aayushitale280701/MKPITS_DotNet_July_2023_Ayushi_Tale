CREATE TABLE Student(Rno INT PRIMARY KEY IDENTITY,
                    Name VARCHAR(50) ,
					Email VARCHAR(50),
					City VARCHAR (50),
					Courseid INT
					)

INSERT INTO Student VALUES ('AYUSHI','ayushi@gmail.com','NAGPUR',111)
INSERT INTO Student VALUES ('PRIYA','priya@gmail.com','MUMBAI',112)
INSERT INTO Student VALUES ('PRAACHI','prachi@gmail.com','DELHI',113)
INSERT INTO Student VALUES ('AYUSH','ayush@gmail.com','NAGPUR',114)
INSERT INTO Student VALUES ('PRIYATI','priyati@gmail.com','MUMBAI',115)
INSERT INTO Student VALUES ('PARI','pri@gmail.com','DELHI',116)

SELECT * FROM Student
--DROP TABLE Student


CREATE TABLE Fees (FeesID INT ,
                    Rno INT,
					Feesdate DATE,
					Amount INT ,
					CourseID INT
					)
INSERT INTO Fees VALUES (221,11,'2023-12-22',20000,111)
INSERT INTO Fees VALUES (222,12,'2023-12-22',25000,112)
INSERT INTO Fees VALUES (223,13,'2023-12-22',30000,113)
INSERT INTO Fees VALUES (224,14,'2023-12-22',40000,114)
INSERT INTO Fees VALUES (225,15,'2023-12-22',20000,115)
INSERT INTO Fees VALUES (226,16,'2023-12-22',15000,116)
SELECT * FROM Fees

SELECT  Rno, Feesdate, CourseID  FROM Fees 
WHERE Rno IN (SELECT Rno FROM Student WHERE City='NAGPUR')

SELECT  Rno, Feesdate, CourseID  FROM Fees 
WHERE Rno IN (SELECT Rno FROM Student WHERE City='MUMBAI')

SELECT  Rno, Feesdate, CourseID  FROM Fees 
WHERE Rno IN (SELECT Rno FROM Student WHERE City='DELHI')
