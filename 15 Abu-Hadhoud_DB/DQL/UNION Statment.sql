
/*
The UNION operator is used to combine the result-set of two or more SELECT statements.

    Every SELECT statement within UNION must have the same number of columns
    The columns must also have similar data types
    The columns in every SELECT statement must also be in the same order

	UNION remove the duplicated rows from the tables
*/
Use HR_Database;

-- 
select * from vwActiveEmployees 
Union
select * from vwResignedEmployees

-----------------

Select * From Departments
UNION 
select * From Departments

--------------------------
--	UNION ALL don't remove the duplicated rows from the tables it just append

Select * From Departments
UNION ALL
Select * From Departments;






