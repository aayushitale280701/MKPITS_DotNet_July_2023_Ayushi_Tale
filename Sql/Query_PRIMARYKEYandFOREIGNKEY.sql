Create table VendorGroups (Group_ID INT IDENTITY PRIMARY KEY,
                           Group_Name VARCHAR(100) NOT NULL);

Create table Vendor (Vendor_ID INT IDENTITY PRIMARY KEY,
                     Vendor_Name VARCHAR(100) NOT NULL,
					 Group_ID INT NOT NULL,
					 CONSTRAINT fk_group FOREIGN KEY (Group_ID)
					 REFERENCES VendorGroups (Group_ID)
					 );

insert into Vendor(Group_ID,Vendor_Name) values (1,'Ayushi')
insert into Vendor(Group_ID,Vendor_Name) values (2,'Om')
insert into Vendor(Group_ID,Vendor_Name) values (3,'Piyush')
insert into Vendor(Group_ID,Vendor_Name) values (4,'Nitin')
insert into Vendor(Group_ID,Vendor_Name) values (5,'Avinash')
Select * from Vendor

insert into VendorGroups values ('MKPITS')
insert into VendorGroups values ('NIIT')
Select * from VendorGroups


