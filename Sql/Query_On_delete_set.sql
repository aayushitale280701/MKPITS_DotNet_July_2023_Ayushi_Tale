Create table VendorGroup4 (Group_ID INT IDENTITY PRIMARY KEY,
                           Vendor_Name VARCHAR(100) NOT NULL)

Create table Vendor4(Vendors_ID INT IDENTITY PRIMARY KEY,
                      Vendor_Name VARCHAR(100) NOT NULL,
					  Group_ID INT,
					  CONSTRAINT fk3 FOREIGN KEY(Group_ID)
					  REFERENCES VendorGroup4(Group_ID)
					  ON DELETE SET NULL
					  )

insert into VendorGroup4 values ('TCS')
insert into VendorGroup4 values ('MKPITS')

insert into Vendor4 values ('Khushi',1)
insert into Vendor4 values ('Ayushi',1)
insert into Vendor4 values ('Khushbu',2)
insert into Vendor4 values ('Ayush',2)
insert into Vendor4 values ('Khushali',3)
insert into Vendor4 values ('Ayush',3)

Delete from VendorGroup4 where Group_ID=2

select * from VendorGroup4 
select * from Vendor4

