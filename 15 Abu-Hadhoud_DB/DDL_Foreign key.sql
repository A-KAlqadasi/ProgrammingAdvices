Use DB2;

CREATE TABLE Customers( 
	id INT,
	first_name VARCHAR(40),
	last_name VARCHAR(40),
	age INT ,
	country VARCHAR(10),
	PRIMARY KEY(id)
);

--adding foreign key to the customer_id field
-- the foreign key references to the id field of the customers table
CREATE TABLE Orders(
	order_id INT,
	item VARCHAR(40),
	amount INT,
	customer_id INT,
	PRIMARY KEY (order_id)
);


-- adding foreign key constraint after create table
Alter table Orders
Add Foreign key (customer_id) REFERENCES Customers(id) ;
