Create table Student(Rollno bigint,S_Name varchar(20), S_Address varchar(50), S_City varchar(20),S_PhoneNo bigint)
Insert into Student values(111,'Ayushi','Dathawaddi','Nagpur',123644795)
Insert into Student values(112,'Ayushree', 'Ajni', 'Nagpur',455974551)
Insert into Student values(113,'Akasha','Madevada','Nagpur',12365897)
Insert into Student values(114,'Chndrima','Ravinagar','Nagpur',489236112)
Insert into Student values(115,'Prachi','Nandanvan','Bhandara',159773356)
Insert into Student values(116,'Sayali','Nandanwan','Gondiaya',156236795)
Insert into Student values(117,'Mayuri', 'Tukdoji Square', 'Ramtek',455892251)
Insert into Student values(118,'Vrushali','Shankarnagre','Arwi',1289234797)
Insert into Student values(119,'Murunali','Itwari','Nagpur',489236112)
Insert into Student values(120,'Reetu','Kamti','Bhandara',159773356)
Select  * From Student Where RollNo=115
Select * From Student Where Rollno>112
Select * From Student Where S_Name='Prachi'
Select * From Student Where S_City='Nagpur'