
Use DB2;

/*
The PRIMARY KEY constraint uniquely identifies each record in a table.

Primary keys must contain UNIQUE values, and cannot contain NULL values.

A table can have only ONE primary key; and in the table,
this primary key can consist of single or multiple columns (fields).
*/

-- the primary key constraint must be not null in the create table
Alter table Persons
Alter Column ID int not null

-- how to add constraint primary key with name pk_Person after creating table
Alter Table Persons
Add Constraint pk_Person primary key (ID);

-- how to drop a primary key constraint
Alter Table Persons
Drop Constraint PK_Person;

-- how to add constraint primary key after creating table
Alter Table Persons
Add Primary key (ID)



