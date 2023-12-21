CREATE TABLE Students (ID INT PRIMARY KEY IDENTITY ,
                       Admission_No VARCHAR (50),
					   First_Name VARCHAR (50),
					   Last_Name VARCHAR  (50),
					   Age INT ,
					   City VARCHAR (50)
					   );

CREATE TABLE Fees (Admission_No VARCHAR(50) NOT NULL,
                   Course VARCHAR (50) NOT NULL,
				   Amount_Paid VARCHAR (50)
				   );

INSERT INTO Students VALUES ('1234','Avinash','Deshmukh',20,'Akola')
INSERT INTO Students VALUES ('2341','Yash','Gite',22,'Nagpur')
INSERT INTO Students VALUES ('1456','Ayuni','Deshmukh',20,'Akola')
INSERT INTO Students VALUES ('1341','Yasharee','Kade',23,'Amravati')
INSERT INTO Students VALUES ('1444','Khushi','Deshmukh',20,'Murtizapur')
INSERT INTO Students VALUES ('2341','Yashi','Gaykvad',22,'Nagpur')

INSERT INTO Fees VALUES ('1456','Dotnet',50000)
INSERT INTO Fees VALUES ('2341','Java',20000)
INSERT INTO Fees VALUES ('1341','C++',25000)
INSERT INTO Fees VALUES ('1444','C Program',15000)

SELECT Students.Admission_No,Students.First_Name,Students.Last_Name,
       Fees.Amount_Paid,Fees.Course
FROM Students CROSS JOIN Fees

------WHERE USING ------

SELECT Students.Admission_No,Students.First_Name,Students.Last_Name,
       Fees.Amount_Paid,Fees.Course
FROM Students CROSS JOIN Fees
WHERE Students.Admission_No = Fees.Admission_No
