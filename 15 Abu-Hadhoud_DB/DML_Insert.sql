use myDB;



select * from employees;

-- insert one record at a time
insert into Employees
values
(1,'Emp1','122313',1000,'M');

-- insert multiple records at a time
insert into Employees
values
(2,'Emp2','34798',2000,'F'),
(3,'Emp3','8739827',2000,'M'),
(4,'Emp4','428798',4999,'M');

-- insert specific columns
insert into Employees(ID,Name)
values
(5,'Emp5') ;


insert into Employees(ID,Name)
values
(6,'Emp6') ;

insert into Employees(Name,ID,Gender)
values
('Emp7',7,'M');

-- this delete all the record from the table
--delete from Employees;

select * from Employees ;