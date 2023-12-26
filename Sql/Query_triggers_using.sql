CREATE TABLE Employee (EmpID INT PRIMARY KEY,
                       EmpName VARCHAR (50)
					   );

CREATE TABLE EmpLog (LogID INT IDENTITY NOT NULL,
                     EmpID INT NOT NULL,
					 Operation NVARCHAR (10) NOT NULL,
					 UpdateDate DATETIME NOT NULL
					 );

CREATE TRIGGER Empt
ON Employee 
FOR INSERT AS
INSERT INTO EmpLog (EmpID,Operation,UpdateDate)
SELECT EmpID ,'INSERT',GETDATE() FROM inserted;

INSERT INTO Employee VALUES(11,'AYUSHI')
SELECT * FROM Employee
SELECT * FROM EmpLog

INSERT INTO Employee VALUES(12,'OM')
SELECT * FROM Employee
SELECT * FROM EmpLog

CREATE TRIGGER trgEmployeeInsert
ON Employee 
FOR INSERT AS
INSERT INTO EmpLog (EmpID,Operation,UpdateDate)
SELECT EmpID,'INSERT',GETDATE() FROM inserted

INSERT INTO Employee VALUES(13,'OMI')
SELECT * FROM Employee
SELECT * FROM EmpLog
