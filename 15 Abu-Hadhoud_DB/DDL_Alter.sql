
Use DB1;

-- To add new column in the table 
Alter  table Employees
Add Degreas varchar(20) NULL,
Email varchar(20) NULL 


------------------------------------------------------
------------------------------------------------------

-- To Rename column name in most DBMS
------Alter Table Employees
------Rename Column Degreas to Degrees;

-- To rename the column name in SQL Server 
-- we use the stored procedure => sp_rename 

exec sp_rename 'employees.Degreas','Degrees','column';
exec sp_rename 'employees.Gender','koko','column' ;
exec sp_rename 'employees.koko','Gender','column';

------------------------------------------------------
------------------------------------------------------

-- How to rename the table name 
-- in most DBMS we use this script

----Alter table Employees
----Rename To Emps;

-- in sql server we use the stored procedure sp_rename
exec sp_rename 'employees','Emps';
exec sp_rename 'emps','Employees';
exec sp_rename 'Employees','employees';
exec sp_rename 'employees','Employees';

------------------------------------------------------
------------------------------------------------------

-- Modify the column content
Alter table Employees 
Alter Column Email nvarchar(100) NULL
------------------------------------------------------
------------------------------------------------------
-- Drop column from the table 

Alter table employees
Drop column Degrees;

Alter table employees
drop column email;

alter table employees
drop column gender;


