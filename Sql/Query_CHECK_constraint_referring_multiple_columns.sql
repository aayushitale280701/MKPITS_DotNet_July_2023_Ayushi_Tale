CREATE TABLE Product6(ProductID INT IDENTITY PRIMARY KEY,
                      ProductName VARCHAR(255) NOT NULL,
					  UnitPrice DEC(10,2) CHECK (UnitPrice > 0),
					  DiscountedPrice DEC (10,2) CHECK (DiscountedPrice > 0),
					  CHECK (DiscountedPrice < UnitPrice )
					  );

--ANOTHER WAY --
create table Product6 (productid int identity primary key,
                       productname varchar (255) Not null,
					   unitprice dec (10,2),
					   discountedprice dec (10,2),
					   check  (unitprice > 0),
					   check (discountedprice >0),
					   check (discountedprice > unitprice));

--or even --
CREATE TABLE products(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2),
    discounted_price DEC(10,2),
    CHECK(unit_price > 0),
    CHECK(discounted_price > 0 AND discounted_price > unit_price)
);


INSERT INTO Product6 (ProductName, UnitPrice, DiscountedPrice) VALUES  ('T.V',499, 20);
INSERT INTO Product6 (ProductName, UnitPrice, DiscountedPrice) VALUES  ('Headphones', 899, 30);
INSERT INTO Product6 (ProductName, UnitPrice, DiscountedPrice) VALUES  ('Keyboard',499, 20);
INSERT INTO Product6 (ProductName, UnitPrice, DiscountedPrice) VALUES  ('Mouse', 299, 10);

SELECT * FROM Product6

