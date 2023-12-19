CREATE TABLE Person4(Person_ID INT IDENTITY PRIMARY KEY ,
                     First_Name VARCHAR (255) NOT NULL,
					 Last_Name VARCHAR (255) NOT NULL,
					 Email_ID VARCHAR(255) UNIQUE
					 );

					 ---ANOTHER WAY---
CREATE TABLE Person4 (personid INT IDENTITY PRIMARY KEY,
                      firstname VARCHAR (255) ,
					  lastname VARCHAR (255),
					  email VARCHAR (255),
					  Unique (email)
					  );


INSERT INTO Person4 VALUES ('Ayushi' , 'Tale', 'ayu@123')
INSERT INTO Person4 VALUES ('Ayush' , 'kade', 'ayush@123')
INSERT INTO Person4 VALUES ('Om' , 'Tale', 'Om@123')
INSERT INTO Person4 VALUES ('Rajesh' , 'Tale', 'raju@123')
INSERT INTO Person4 VALUES ('Ritu' , 'Tale', 'ritu@123')

SELECT * FROM Person4


