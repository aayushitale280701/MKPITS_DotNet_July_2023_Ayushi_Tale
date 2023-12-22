SELECT * FROM Student

CREATE TABLE Courses (CourseID INT , 
                      CourseName VARCHAR (25),
					  Fees INT  ,
					  Duration VARCHAR(25)
					  )
INSERT INTO Courses VALUES (11,'DOTNET',20000,'6 MOUNTH')
INSERT INTO Courses VALUES (12,'PHP',10000,'6 MOUNTH')
INSERT INTO Courses VALUES (13,'JAVA',25000,'6 MOUNTH')
INSERT INTO Courses VALUES (14,'PHP',10000,'6 MOUNTH')
INSERT INTO Courses VALUES (15,'JAVA',25000,'6 MOUNTH')
INSERT INTO Courses VALUES (16,'DOTNET',20000,'6 MOUNTH')
SELECT * FROM Courses
--DROP TABLE Courses

SELECT  Fees, CourseName, CourseID  FROM Courses
WHERE Fees IN (SELECT Fees FROM Courses WHERE CourseName='JAVA')

SELECT  Fees, CourseName, CourseID  FROM Courses
WHERE Fees IN (SELECT Fees FROM Courses WHERE CourseName='DOTNET')


SELECT  Fees, CourseName, CourseID  FROM Courses
WHERE Fees IN (SELECT Fees FROM Courses WHERE CourseName='PHP')


