CREATE TABLE ProductCheck1(product_id INT IDENTITY PRIMARY KEY,
                           product_name VARCHAR(255) NOT NULL,
                           unit_price DEC(10,2) CONSTRAINT positive_price CHECK(unit_price > 0)
						  );

insert into ProductCheck1 (product_name, unit_price) values('Bick', 0);

--The error occurred because the unit price is not greater than zero as specified in the CHECK constraint.--

insert into ProductCheck1 (product_name, unit_price) values ('Bick', 689);
--The following statement works fine because the logical expression defined in the CHECK constraint evaluates to TRUE--

select * from ProductCheck1
