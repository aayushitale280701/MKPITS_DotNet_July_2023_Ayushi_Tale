CREATE TABLE Student (ID INT PRIMARY KEY IDENTITY,
                      Admission_No VARCHAR(50),
					  First_Name VARCHAR (50),
					  Last_Name VARCHAR (50),
					  Age INT,
					  City VARCHAR(50)
					  );

CREATE TABLE  Fees (Admission_No VARCHAR(50) NOT NULL,
                    Course VARCHAR(50) NOT NULL,
					Amount_Paid INT 
					);

INSERT INTO Student (admission_no, first_name, last_name, age, city) VALUES ('1111','Ayushi','Tale',21,'Murtizapur')
INSERT INTO Student (admission_no, first_name, last_name, age, city) VALUES ('1121','Ayush','Tekade',22,'Nagpur')
INSERT INTO Student (admission_no, first_name, last_name, age, city) VALUES ('1123','Avinash','Goykar',23,'Murtizapur')
INSERT INTO Student (admission_no, first_name, last_name, age, city) VALUES ('1156','Om','Tale',24,'Ngapur')
INSERT INTO Student (admission_no, first_name, last_name, age, city) VALUES ('1562','Aradhaya','Deshmukh',25,'Murtizapur')

INSERT INTO Fees (admission_no, course, amount_paid)  VALUES ('1111','DotNet',65000)
INSERT INTO Fees (admission_no, course, amount_paid)  VALUES ('1121','Java',30000)
INSERT INTO Fees (admission_no, course, amount_paid)  VALUES ('1123','C++',35000)
INSERT INTO Fees (admission_no, course, amount_paid)  VALUES ('1156','Csharp',40000)
INSERT INTO Fees (admission_no, course, amount_paid)  VALUES ('1562','C Programming',20000)

SELECT Student.Admission_No,Student.First_Name,Student.Last_Name,Fees.Course,Fees.Amount_Paid 
FROM Student INNER JOIN Fees
ON Student.Admission_No = Fees.Admission_No
