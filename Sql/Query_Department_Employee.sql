CREATE TABLE Department (DepartmentID INT PRIMARY KEY,
                          DepartmentName NVARCHAR(100) NOT NULL
                         );

CREATE TABLE Employee (EmployeeID INT PRIMARY KEY,
                        EmployeeName NVARCHAR(100) NOT NULL,
                        DepartmentID INT,
                        CONSTRAINT FK_Department FOREIGN KEY (DepartmentID)
						REFERENCES Department(DepartmentID)
                       );

INSERT INTO Department (DepartmentID, DepartmentName)VALUES (1, 'Engineering')
INSERT INTO Department (DepartmentID, DepartmentName)VALUES (2, 'Marketing')
INSERT INTO Department (DepartmentID, DepartmentName)VALUES (3, 'Sales')

INSERT INTO Employee (EmployeeID, EmployeeName, DepartmentID) VALUES (1, 'John Doe', 1)
INSERT INTO Employee (EmployeeID, EmployeeName, DepartmentID) VALUES (2, 'Jane Smith', 2)
INSERT INTO Employee (EmployeeID, EmployeeName, DepartmentID) VALUES (3, 'Bob Johnson', 1)
INSERT INTO Employee (EmployeeID, EmployeeName, DepartmentID) VALUES (4, 'Alice Brown', 3)


INSERT INTO Employee (EmployeeID, EmployeeName, DepartmentID) VALUES (5, 'Sam Wilson', 2);

UPDATE Employee SET DepartmentID = 3 WHERE EmployeeID = 1;

SELECT e.EmployeeID, e.EmployeeName, d.DepartmentName FROM Employee e, Department d WHERE e.DepartmentID = d.DepartmentID;
SELECT e.EmployeeID, e.EmployeeName, d.DepartmentName FROM Employees e, Departments d WHERE e.DepartmentID = d.DepartmentID;
