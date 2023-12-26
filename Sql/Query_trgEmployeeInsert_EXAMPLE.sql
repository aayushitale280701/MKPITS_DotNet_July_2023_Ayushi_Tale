CREATE TABLE Employee(EmployeeID INT PRIMARY KEY NOT NULL,
                      FirstName VARCHAR(50),
					  LastName VARCHAR (50),
					  Email VARCHAR(50),
					  Phone BIGINT,
					  HireDate DATE,
					  ManagerID INT NULL,
					  Salary INT,
					  DepartmentID INT
					  );

CREATE TABLE EmpLog (LogID INT IDENTITY NOT NULL,
                     EmpID INT NOT NULL,
					 Operation NVARCHAR (10) NOT NULL,
					 UpdatedDate DATETIME NOT NULL
					 )

CREATE TRIGGER Empt 
ON Employee 
FOR INSERT AS 
INSERT INTO EmpLog (EmpID,Operation,UpdatedDate)
SELECT EmployeeID,'INSERT',GETDATE()FROM inserted;

INSERT INTO Employee VALUES (1,'John','King','join.king@qae.com',1231231834,'2010-01-04','   ',95000,10)
INSERT INTO Employee VALUES (4,'James','Bond','jbond22@abc.com',1235647878,'2015-05-01',1,67000,60)
INSERT INTO Employee VALUES (3,'Yangya','Chol','Ychoi@xxx.com',6657890980,'2018-09-10',2,44000,20)

SELECT * FROM Employee 
SELECT * FROM dbo.EmpLog
SELECT * FROM dbo.Employee