CREATE TABLE  EMPLOYEE (   EMP_ID INT PRIMARY KEY,	EMP_NAME VARCHAR(25),	EMP_ZIP INT )

INSERT INTO EMPLOYEE VALUES (    222 	,'	Harry', 		201010)
INSERT INTO EMPLOYEE VALUES (    333 	,'	Stephan ',	02228)
INSERT INTO EMPLOYEE VALUES (    444 	,'	Lan ',		60007)
INSERT INTO EMPLOYEE VALUES (    555 	,'	Katharine ', 	06389)
INSERT INTO EMPLOYEE VALUES (    666 	,'	John ',		462007)

SELECT * FROM EMPLOYEE

CREATE TABLE STATES ( EMP_ZIP INT PRIMARY KEY, SATE_NAME VARCHAR (25), COUNTRY_ID INT)

INSERT INTO STATES VALUES (201010,'		maharashtra',		101)
INSERT INTO STATES VALUES (02228,'		mp	',		101)
INSERT INTO STATES VALUES (60007,'		UP',		101)
INSERT INTO STATES VALUES (06389,'		j&k	',		101)
INSERT INTO STATES VALUES (462007,'		maharashtra',		101)


CREATE TABLE COUNTRY (COUNTRY_ID INT PRIMARY KEY, COUNTRY_NAME VARCHAR (25))
INSERT INTO COUNTRY VALUES (101	,'		india')
INSERT INTO COUNTRY VALUES (102		,	'shrilanka')

SELECT * FROM EMPLOYEE
SELECT * FROM STATES 
SELECT * FROM COUNTRY





