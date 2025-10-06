
/*
The CHECK constraint is used to limit the value range that can be placed in a column.

If you define a CHECK constraint on a column it will allow only certain values for this column.

If you define a CHECK constraint on a table it can limit the values
in certain columns based on values in other columns in the row.
*/

Create table Persons
(
	ID int Not null,
	FirstName varchar(50) not null,
	lastName varchar(50) ,
	Age int check(age >=18)
);

Create table Persons
(
	ID int Not null,
	FirstName varchar(50) not null,
	lastName varchar(50) ,
	Age int ,
	City nvarchar(255) ,
	CONSTRAINT chk_Person CHECK(Age>=18 and City='Taiz')
);

--- 
Alter table Persons
Add constraint chk_Person check(Age>=18)


-----------
--Drop check constraint 
alter table Persons
drop constraint chk_Person