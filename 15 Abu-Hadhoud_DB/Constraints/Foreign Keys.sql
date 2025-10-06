use DB2;
/*
The FOREIGN KEY constraint is used to prevent actions that
would destroy links between tables.

A FOREIGN KEY is a field (or collection of fields) in one table,
that refers to the PRIMARY KEY in another table.
*/
drop table Orders;

create table Orders
(
	OrderID int primary key,
	OrderNumber int not null,
	PersonID int ,
	Constraint fk_PersonId foreign key(PersonID)   
	references Persons(ID)
	
);

-- how to drop foreign key constraint
Alter Table Orders
Drop Constraint FK__Orders__PersonID__656C112C ;

-- how to add foreign key constraint with name after creating the table 
Alter table Orders
Add Constraint fk_PersonOrder foreign key(PersonID) references Persons(ID);

-- how to add foreign key constraint after creating the table 
Alter table Orders
Add Foreign key(PersonID) references Persons(Id);








