Create table VendorGroup2 (Group_ID INT IDENTITY PRIMARY KEY,
                           Vendor_Name VARCHAR(100) NOT NULL)

Create table Vendor2(Vendor_ID INT IDENTITY PRIMARY KEY,
                     Vendor_Name VARCHAR (100) NOT NULL,
					 Group_ID INT NOT NULL,
					 CONSTRAINT FK11 FOREIGN KEY (Group_ID)
					 REFERENCES VendorGroup2 (Group_ID)
					 ON DELETE NO ACTION)

insert into VendorGroup2 values ('Ayushi')
insert into VendorGroup2 values ('Sakshi')

insert into Vendor2 values ('Omshree',2)
insert into Vendor2 values ('Piyush',2)
insert into Vendor2 values ('Nitin',1)
insert into Vendor2 values ('Avinash',1)

select * from VendorGroup2
Select * from Vendor2

delete from Vendor2 where Group_ID = 1;
