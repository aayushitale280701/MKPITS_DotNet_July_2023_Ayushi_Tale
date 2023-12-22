CREATE TABLE stores2 (store_id INT IDENTITY (1, 1) PRIMARY KEY,
	                 store_name VARCHAR (255) NOT NULL,
	                 phone VARCHAR (25),
	                 email VARCHAR (255),
	                 street VARCHAR (255),
	                 city VARCHAR (255),
	                 state VARCHAR (10),
	                 zip_code VARCHAR (5)
                    );

insert into stores2(store_name,phone,email,street,city,state,zip_code) values ('Guruji ','1234567890','guruji@gmail.com','Old City','Akola','Maharastra','4441')
insert into stores2(store_name,phone,email,street,city,state,zip_code) values ('Dhanush','2234567890','dhanu@gmail.com','Sadar','Nagpur','Maharastra','4400')
insert into stores2(store_name,phone,email,street,city,state,zip_code) values ('D Mart','1234567890','mart@gmail.com','Sadar','Nagpur','Maharastra','4400')
insert into stores2(store_name,phone,email,street,city,state,zip_code) values ('Galaxy','2234567890','gal@gmail.com','Sadar','Nagpur','Maharastra','4400')
SELECT * FROM stores2

CREATE TABLE Staffs22 (staff_id INT PRIMARY KEY,
	                 first_name VARCHAR (50) NOT NULL,
	                 last_name VARCHAR (50) NOT NULL,
	                 email_adrress VARCHAR (50) NOT NULL ,
	                 phone VARCHAR (25),
	                 active Int NOT NULL,
	                 store_id INT NOT NULL,
	                 manager_id INT,
					 constraint  fk17 
	                 FOREIGN KEY (store_id) 
                     REFERENCES stores2 (store_id)  
                    );
					

insert into Staffs22 values (11,'Ayushi','Tale','ayushii@gmail.com','753789123',2,1,111)
insert into Staffs22 values (22,'Ayush','Tekade','ayui@gmail.com','256789123',3,2,112)
insert into Staffs22 values (33,'Aradhaya','Deshmukha','aaru@gmail.com','75345673',4,3,113)
insert into Staffs22 values (44,'Om','Tale','om@gmail.com','987789123',5,4,114)
SELECT * FROM Staffs22

CREATE TABLE Categories3(category_id INT PRIMARY KEY,
	                    category_name VARCHAR (255) NOT NULL
						);

insert into Categories3 values(141,'Children bicycles')
insert into Categories3 values(142,'Comfort bicycles')
insert into Categories3 values(143,'Electric bikes')
insert into Categories3 values(144,'Bikes')
SELECT * FROM Categories3

CREATE TABLE Brande1 (brand_id INT PRIMARY KEY,
                     brand_name VARCHAR (255) NOT NULL
					 );

insert into Brande1 values(151,'Electra')
insert into Brande1 values(152,'Haro')
insert into Brande1 values(153,'Heller')
insert into Brande1 values(154,'Mahindra')
SELECT * FROM Brande1

CREATE TABLE Products222 (product_id INT PRIMARY KEY,
	                   product_name VARCHAR (255) NOT NULL,
	                   brand_id INT NOT NULL,
	                   category_id INT NOT NULL,
	                   model_year INT NOT NULL,
	                   list_price DECIMAL NOT NULL,constraint fk123
	                   FOREIGN KEY (category_id) 
                       REFERENCES Categories3 (category_id), 
                       constraint fk124
	                   FOREIGN KEY (brand_id) 
                       REFERENCES Brande1 (brand_id) 
                  
                      );

insert into Products222 values (1,'Electic oil',151,141,2022,1000)
insert into Products222 values (2,'Front Wheel',152,142,2020,2000)
insert into Products222 values (3,'Number Plate',153,143,2023,900)
insert into Products222 values (4,'Back Wheel',154,144,2022,1000)
SELECT * FROM Products222

CREATE TABLE Sales_customers1 (customer_id INT IDENTITY PRIMARY KEY,
	                          first_name VARCHAR (255) NOT NULL,
	                          last_name VARCHAR (255) NOT NULL,
	                          phone VARCHAR (25),
	                          email VARCHAR (255) NOT NULL,
	                          street VARCHAR (255),
	                          city VARCHAR (50),
	                          state VARCHAR (25),
	                          zip_code VARCHAR (5)
                             );

insert into Sales_customers1 values ('Avinash','Tale','753789123','avi@gmail.com','Sadar','Nagpur','Maharashtra','1111')
insert into Sales_customers1 values ('Manoj','Tekade','751239123','mnoj@gmail.com','Manevada','Nagpur','Maharashtra','1121')
insert into Sales_customers1 values ('Anurag','Deshmukha','89489123','anurag@gmail.com','Besa','Nagpur','Maharashtra','1211')
insert into Sales_customers1 values ('Omkar','Tale','956789123','om@gmail.com','Kamti','Nagpur','Maharashtra','1891')
SELECT * FROM Sales_customers1

CREATE TABLE Sales_orders23 (order_id INT PRIMARY KEY,
	                       customer_id INT,
	                       order_status VARCHAR(20),
	                       order_date DATE NOT NULL,
	                       required_date DATE NOT NULL,
	                       shipped_date DATE,
	                       store_id INT NOT NULL,
	                       staff_id INT NOT NULL,
						   constraint fk111
	                       FOREIGN KEY (customer_id) 
                           REFERENCES Sales_customers1 (customer_id) ,
						   constraint fk112 
	                       FOREIGN KEY (store_id) 
                           REFERENCES stores2 (store_id) ,
                           constraint fk113
	                       FOREIGN KEY (staff_id) 
                           REFERENCES Staffs22 (staff_id) 
                          );

insert into Sales_orders23 values (1,1,'cANCEL','2022-10-11','2023-10-17','2023-10-20',1,11)
insert into Sales_orders23 values (2,2,'PURCHASED','2023-09-11','2023-10-23','2023-10-05',2,22)
insert into Sales_orders23 values (3,3,'cANCEL','2023-10-11','2023-10-17','2023-10-05',3,33)
insert into Sales_orders23 values (4,4,'PURCHASED','2023-10-09','2023-10-17','2023-10-05',4,44)
SELECT * FROM Sales_orders23


CREATE TABLE sales_order_items111(order_id INT,
                   	           item_id INT ,
	                           product_id INT NOT NULL,
	                           quantity INT NOT NULL,
	                           list_price DECIMAL (10, 2) NOT NULL,
	                           discount DECIMAL (4, 2) NOT NULL DEFAULT 0,
	                           PRIMARY KEY (order_id, item_id),
	                           FOREIGN KEY (order_id) 
                               REFERENCES Sales_orders23 (order_id) 
                               ON DELETE CASCADE ON UPDATE CASCADE,
	                           FOREIGN KEY (product_id) 
                               REFERENCES Products111 (product_id) 
                               ON DELETE CASCADE ON UPDATE CASCADE
                              );

insert into sales_order_items111 values (1,1,1,5,1000,20)
insert into sales_order_items111 values (2,2,2,2,2000,10)
insert into sales_order_items111 values (3,3,3,4,900,25)
insert into sales_order_items111 values (4,4,4,3,1000,10)
SELECT * FROM sales_order_items111

CREATE TABLE production_stocks (store_id INT,
	                            product_id INT,
	                            quantity INT,
	                            PRIMARY KEY (store_id, product_id),
	                            FOREIGN KEY (store_id) 
                                REFERENCES stores2 (store_id) 
                                ON DELETE CASCADE ON UPDATE CASCADE,
	                            FOREIGN KEY (product_id) 
                                REFERENCES products111 (product_id) 
                                ON DELETE CASCADE ON UPDATE CASCADE
                                );

insert into production_stocks values (1,1,5)
insert into production_stocks values (2,2,2)
insert into production_stocks values (3,3,4)
insert into production_stocks values (4,4,3)
SELECT * FROM production_stocks

--EXECUTE--.
SELECT * FROM stores2
SELECT * FROM Staffs22
SELECT * FROM Categories3
SELECT * FROM Brande1
SELECT * FROM Products111
SELECT * FROM Sales_customers1
SELECT * FROM Sales_orders23
SELECT * FROM sales_order_items111
SELECT * FROM production_stocks


