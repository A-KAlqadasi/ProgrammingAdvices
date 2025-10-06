
select * from Employees;

-- to make a copy from the table 
-- the name of the copy table must not be exists


select * 
into EmployeesCopy1
from Employees;

select * from EmployeesCopy1 ;


select ID, Name 
into EmployeesCopy2
From Employees;

select * from EmployeesCopy2;

-- if i want to copy the schema of the table only 
-- we make the condition false 

select * 
into EmployeesCopy3
from Employees
where 5 = 6 ;

select *from EmployeesCopy3 ;

