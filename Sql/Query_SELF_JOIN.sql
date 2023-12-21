CREATE TABLE MKPITS_Student (ID INT PRIMARY KEY IDENTITY,
                             First_Name VARCHAR (25),
							 Last_Name VARCHAR (25),
							 City VARCHAR (25)
							 );

INSERT INTO MKPITS_Student VALUES ('Ayushi','Tale','Murtizapur')
INSERT INTO MKPITS_Student VALUES ('Avinash','Deshmukh','Akola')
INSERT INTO MKPITS_Student VALUES ('Ayush','Tekade','Nagpur')
INSERT INTO MKPITS_Student VALUES ('Ayuni','Deshmukh','Akola')
INSERT INTO MKPITS_Student VALUES ('Tanushi','Patinge','Mumbai')
INSERT INTO MKPITS_Student VALUES ('Aradhaya','Kade','Pune')
INSERT INTO MKPITS_Student VALUES ('Om','Tale','Nagpur')

SELECT * FROM MKPITS_Student 
SELECT M1.First_Name, M2.Last_Name , M2.City 
FROM MKPITS_Student M1 , MKPITS_Student M2
WHERE M1.ID <> M2.ID
AND M1.City = M2.City
ORDER BY M2.City


   