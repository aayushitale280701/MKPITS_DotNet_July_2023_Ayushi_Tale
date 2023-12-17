Create Table VendorGroup5(Group_ID INT IDENTITY PRIMARY KEY,
                          Group_Name VARCHAR(100) NOT NULL)

Create Table Vendor5 (Vendor_ID INT IDENTITY PRIMARY KEY,
                      Vendor_Name VARCHAR (100) NOT NULL,
					  Group_ID INT,
					  CONSTRAINT FK3 FOREIGN KEY (Group_Id)
					  REFERENCES VendorGroup5 (Group_ID)
					  ON DELETE SET NULL)

insert into VendorGroup5(Group_Name)values ('TCS')
insert into VendorGroup5(Group_Name) values ('TATA')
insert into VendorGroup5(Group_Name)values ('ITP')

insert into Vendor5(Vendor_Name,Group_ID) values ('Ayushi',1)
insert into Vendor5(Vendor_Name,Group_ID) values ('Om',2)
insert into Vendor5(Vendor_Name,Group_ID) values ('Ritu',3)
insert into Vendor5(Vendor_Name,Group_ID) values ('Rajesh',3)

UPDATE VendorGroup5 SET Group_Name='MKPITS' WHERE Group_ID=3

SELECT * FROM VendorGroup5
SELECT * FROM Vendor5