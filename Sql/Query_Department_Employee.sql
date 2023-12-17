CREATE TABLE Departments (DepartmentID INT PRIMARY KEY,
                          DepartmentName NVARCHAR(100) NOT NULL
                         );

CREATE TABLE Employees (EmployeeID INT PRIMARY KEY,
                        EmployeeName NVARCHAR(100) NOT NULL,
                        DepartmentID INT,
                        CONSTRAINT FK_Department_Employee FOREIGN KEY (DepartmentID)
						REFERENCES Departments(DepartmentID)
                       );

INSERT INTO Departments (DepartmentID, DepartmentName)VALUES (1, 'Engineering')
INSERT INTO Departments (DepartmentID, DepartmentName)VALUES (2, 'Marketing')
INSERT INTO Departments (DepartmentID, DepartmentName)VALUES (3, 'Sales')

INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID) VALUES (1, 'John Doe', 1)
INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID) VALUES (2, 'Jane Smith', 2)
INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID) VALUES (3, 'Bob Johnson', 1)
INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID) VALUES (4, 'Alice Brown', 3)