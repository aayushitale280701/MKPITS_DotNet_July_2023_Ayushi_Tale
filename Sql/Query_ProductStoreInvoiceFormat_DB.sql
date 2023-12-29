create table TableProductGSTDetails (Product_Gst_ID int primary key,
                                     GstDetails_Name varchar (500),
									 CGST decimal,
									 SGST decimal,
									 IGST decimal
									 )
insert into TableProductGSTDetails values (111,'Mobile',150.00,45.00,85.00),
                                          (112,'Laptop',2000.00,1000.00,2500.00),
										  (113,'Headphone',50.00,100.00,75.00)
										  


create table TableProductCategory (Product_Category_ID  int primary key,
                                  Product_Type_Name varchar(500),
								  Product_GST_ID int constraint fk1 foreign key ( Product_Gst_ID)
								  references TableProductGSTDetails (Product_Gst_ID)
								  )
insert into TableProductCategory values (201,'Keyboard',111),
                                      (202,'Mouse',112),
									  (203,'CPU',113)
									   


create table TableProduct (Product_ID int primary key,
                           ProductTypeID int,
						   Product_Name varchar(500)
						   )
insert into TableProduct values (501,11,'Scale'),
                                (502,12,'Pen'),
								(503,13,'Pencile')



create table TableInvoiceDetaiIs (Invoice_Detail_ID int primary key,
                                  Customer_Name varchar(500),
								  Customer_Contact varchar(500),
								  Product_Category_ID int constraint fk11 foreign key (Product_Category_ID)
								  references TableProductCategory (Product_Category_ID),
								  Product_ID int constraint fk12 foreign key (Product_ID)
								  references TableProduct (Product_ID),
								  Residential_Type_ID int,
								  Invoice_Date datetime,
								  Quantity decimal,
								  Price decimal,
								  CGST decimal,
								  SGST decimal,
								  IGST decimal,
								  CGST_Value decimal,
								  SGST_Value decimal,
								  IGST_Value decimal,
								  Total_Amount decimal
								  )
insert into TableInvoiceDetaiIs values (1101,'Ayushi','9876543210',201,501,1,'2023/10/23',05.00,2000,150.00,45.00,85.00,22.00,33.00,44.00,20000),
                                       (1102,'Om','3216549870',202,502,2,'2023/12/23',10.00,3000,10.00,20.00,30.00,11.00,22.00,33.00,30000),
									   (1103,'Ritu','7418529630',203,503,3,'2023/12/22',11.00,4000,11.00,30.00,40.00,11.00,22.00,33.00,25000)


select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetaiIs