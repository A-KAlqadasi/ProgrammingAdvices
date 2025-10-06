use HR_Database;


-- we use view to store select statment .
-- when we select on it, it just goes to execute the select statment inside it.
-- view always shows up-to-date data! The database engine recreates 
		--the view, every time a user queries it.

select * from Employees
where ExitDate is NOT NULL ;


select * from vwActiveEmployees;

select * from vwResignedEmployees;


Create view vwShortDetailEmployees as
select ID, FirstName,LastName,Gender
from Employees;

select * from vwShortDetailEmployees;


