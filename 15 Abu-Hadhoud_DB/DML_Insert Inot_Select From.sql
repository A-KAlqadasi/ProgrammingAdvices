
Use DB2;

-- insert into .. select from
-- we use it to insert data from one table into another from the select
-- satatment
-- the new table must be already created and exist with the same datatypes 

select * from persons;

select * from OldPersons;

delete from oldPersons;


insert into OldPersons
select from Persons
where Age >=30;

insert into OldPersons(Id,Name)
select ID,Name from Persons
where Age >=30;




