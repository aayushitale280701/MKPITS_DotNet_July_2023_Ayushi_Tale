CREATE TABLE Person55 (PersonID INT IDENTITY PRIMARY KEY ,
                      FirstName varchar (255),
					  LastName varchar (255),
					  Email varchar (255),
					  CONSTRAINT Unique_Email UNIQUE(Email)
					  );
INSERT INTO Person55 VALUES ('Ayushi' , 'Tale', 'ayu@123')
INSERT INTO Person55 VALUES ('Ayush' , 'kade', 'ayush@123')
INSERT INTO Person55 VALUES ('Om' , 'Tale', 'Om@123')
INSERT INTO Person55 VALUES ('Rajesh' , 'Tale', 'raju@123')
INSERT INTO Person55 VALUES ('Ritu' , 'Tale', 'ritu@123')

SELECT * FROM Person55
