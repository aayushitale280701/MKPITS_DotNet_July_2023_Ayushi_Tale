create table TableProductGSTDetail(Product_GST_ID int primary key, 
                                   GstDetail_Name varchar (500),
                                   CGST decimal,
								   SGST decimal,
								   IGST decimal
								   )
insert into TableProductGSTDetail values(601,'AC and Fridge',14,14,14),
                                        (602,'Computer',9,9,9),
                                        (603,'Printers',9,9,9),
                                        (604,'Mobiles',6,6,6)



create table TableProductCategory (Product_Category_id int primary key,
                                    Product_Type_Name varchar(500),
                                    Product_GSt_ID int foreign key(Product_GST_ID) 
									references TableProductGSTDetail(Product_GST_ID)
									)
insert into TableProductCategory values (1001,'Computer',602),
                                         (1002,'Mobiles',604),
                                         (1003,'Printers',603),
										 (1004,'AC and Fridge',601)



create table TableProduct(ProductId int primary key,
                          ProductName varchar(500),
                          Product_Category_id int foreign key(Product_Category_id) 
						  references TableProductCategory(Product_Category_id),
						  ProductPrice int
						 )
insert into TableProduct values(210,'Apple',1002,40000),
                               (211,'Lenevo',1002,25000),
                               (212,'Samsung',1003,50000),
                               (213,'IFB',1004,20000),
                               (214,'LG',1004,30000),
                               (215,'Sony',1001,60000)



create table TableInvoiceDetails(Invoice_Detail_Id int primary key,
                                 Customer_Name varchar(500),
								 Customer_Contact varchar(15),
                                 Product_Category_id int foreign key (Product_Category_id)
                                 references TableProductCategory(Product_Category_id),
                                 ProductId int foreign key(ProductId)
                                 references TableProduct(ProductId),Residential_Type_Id int,
                                 Invoice_Date datetime,
								 Quantity decimal,
                                 Price decimal,
								 CGST decimal,
								 SGST decimal,
                                 IGST decimal,
								 CGST_value decimal,
								 SGST_Value decimal,
                                 IGST_Value decimal,
								 TotalAmount decimal
								 )


select * from TableProductGSTDetail
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails
