Create table VendorGroups (Group_ID INT IDENTITY PRIMARY KEY,
                           Group_Name VARCHAR(100) NOT NULL);

Create table Vendor (Vendor_ID INT IDENTITY PRIMARY KEY,
                     Vendor_Name VARCHAR(100) NOT NULL,
					 Group_ID INT NOT NULL);

insert into Vendor(Vendor_Name,Group_ID) values('AYUSHI',123)
select * from Vendor
select * from VendorGroups

