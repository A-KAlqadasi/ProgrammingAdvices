use DB4;



-- to create index on the last name field (non-unique)
create INDEX idx_lastName
On Persons(lastName) ;

-- to create index on field that has unique constraint use
create unique index idx_id_firstName
on persons(id,firstName);

-- to drop index by its name 
drop index Persons.idx_lastName

create index idx_pname
on persons(FirstName,LastName) ;

-- drop index
drop index persons.idx_pname;


