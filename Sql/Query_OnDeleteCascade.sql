Create table VendorGroup3 (Group_ID INT IDENTITY PRIMARY KEY,
                           Vendor_Name VARCHAR(100) NOT NULL)

Create table Vendor3(Vendor_ID INT IDENTITY PRIMARY KEY,
                     Vendor_Name VARCHAR (100) NOT NULL,
					 Group_ID INT NOT NULL,
					 CONSTRAINT FK11 FOREIGN KEY (Group_ID)
					 REFERENCES VendorGroup3 (Group_ID)
					 ON DELETE CASCADE)

insert into VendorGroup3 values ('Ayushi')
insert into VendorGroup3 values ('Sakshi')

insert into Vendor3 values ('Omshree',2)
insert into Vendor3 values ('Piyush',2)
insert into Vendor3 values ('Nitin',1)
insert into Vendor3 values ('Avinash',1)

select * from VendorGroup3
Select * from Vendor3

delete from VendorGroup3 where Group_ID = 1;
