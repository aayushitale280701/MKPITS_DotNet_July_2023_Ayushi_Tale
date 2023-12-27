CREATE TABLE Employees (EmployeeID INT PRIMARY KEY,
                               EmpName VARCHAR (50),
							   Email VARCHAR (50),
							   Phone BIGINT,
							   Salary INT,
							   DepartmentID int
							   );

INSERT INTO Employees VALUES (11,'AYUSHI','ayushi@123',989712564,45000,2)
INSERT INTO Employees VALUES (22,'OMI','omi@423',562348912,35000,2)
INSERT INTO Employees VALUES (33,'RITU','ritu@9897',852963741,50000,2)
INSERT INTO Employees VALUES (44,'AYUSH','ayush@123',989712564,45000,2)
INSERT INTO Employees VALUES (55,'OM','om@423',562348912,35000,2)
INSERT INTO Employees VALUES (66,'RITARI','rita@9897',852963741,50000,2)

SELECT * FROM Employees 

CREATE  PROCEDURE  GetAverageSalary (@AvgSalary as int)
                                  
AS 
BEGIN
SELECT @AvgSalary AVG(Salary) FROM Employees;
END;

EXEC GetAverageSalary @AvgSalary = Salary 

EXEC GetEmployeeBy 35000

