CREATE TABLE TrackNewEmployee (EmployeeID INT PRIMARY KEY,
                               EmpName VARCHAR (50),
							   Email VARCHAR (50),
							   Phone BIGINT,
							   Salary INT
							   );
 
CREATE TABLE EmployeeLog (LogID INT IDENTITY (1,1),
                          EmpID INT,
						  Opration NVARCHAR(10),
						  UpdatedDate DATETIME
						  );

CREATE TRIGGER EmpTrg
ON TrackNewEmployee 
FOR INSERT AS
INSERT INTO EmployeeLog(EmpID,Opration,UpdatedDate)
SELECT EmployeeID, 'INSERTED',GETDATE () FROM INSERTED;

INSERT INTO TrackNewEmployee VALUES (11,'AYUSHI','ayushi@123',989712564,45000)
INSERT INTO TrackNewEmployee VALUES (22,'OMI','omi@423',562348912,35000)
INSERT INTO TrackNewEmployee VALUES (33,'RITU','ritu@9897',852963741,50000)

SELECT * FROM TrackNewEmployee 
SELECT * FROM EmployeeLog