CREATE TABLE products7(
                          product_id INT IDENTITY PRIMARY KEY,
                          product_name VARCHAR(255) NOT NULL,
                          unit_price DEC(10,2) NOT NULL
                      );

ALTER TABLE products
ADD CONSTRAINT positive_price CHECK(unit_price > 0);
ALTER TABLE products ADD discounted_price DEC(10,2) CHECK(discounted_price > 0);

ALTER TABLE products7 ADD discounted_price DEC (10,2) CHECK (discounted_price >0);

ALTER TABLE products
ADD CONSTRAINT valid_price CHECK(unit_price > discounted_price);

--To remove a CHECK constraint, you use the ALTER TABLE DROP CONSTRAINT statement:

ALTER TABLE table_name
DROP CONSTRAINT constraint_name;
