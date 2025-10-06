/*
The DEFAULT constraint is used to set a default value for a column.

The default value will be added to all new records, if no other value is specified.
*/

use DB3;


Create table Persons
(
	ID int Not null,
	FirstName varchar(50) not null,
	lastName varchar(50) ,
	Age int,
	City varchar(255) Default 'Taiz'
);

create table Orders
(
	ID int not null,
	OrderNumber int not null,
	OrderDate date default GETDATE()
);

Create table Persons
(
	ID int Not null,
	FirstName varchar(50) not null,
	lastName varchar(50) ,
	Age int,
	City varchar(255)
);

-- to add default constraint after creating the table
Alter table Persons
Add Constraint df_City
Default 'Taiz' For City;


-- to drop default constraint
Alter table Persons
Drop constraint df_City;

