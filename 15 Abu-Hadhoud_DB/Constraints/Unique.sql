

/*
The UNIQUE constraint ensures that all values in a column are different.

Both the UNIQUE and PRIMARY KEY constraints provide a guarantee
for uniqueness for a column or set of columns.

A PRIMARY KEY constraint automatically has a UNIQUE constraint.

However, you can have many UNIQUE constraints per table,
but only one PRIMARY KEY constraint per table.

*/

use DB4;

create table Persons
(
	ID int not null Unique,
	FirstName varchar(255),
	LastName varchar(255),
	Age int
);

drop table Persons;

-- unique constraint on two fields
create table Persons
(
	Id int not null,
	FirstName nvarchar(255),
	LastName nvarchar(255),
	Age int,
	Constraint uc_Person UNIQUE (ID,LastName)
);

---------
Alter table Persons
Add Unique(ID);

Alter table Persons
Add constraint uc_Person UNIQUE(ID,LastName) ;

Alter table Persons
Drop constraint uc_Person ;







