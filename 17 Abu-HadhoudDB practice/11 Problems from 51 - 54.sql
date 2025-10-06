--Queries Problem Solving ProgarmmingAdvices
Use EmployeesDB ;

select * from Employees;

--  Problem 51: Get all employees that have manager along with Manager's name.

select * from Employees

select E.*, M.Name as ManagerName 

from Employees E 
join Employees M
on (E.ManagerID = M.EmployeeID)


--  Problem 52: Get all employees that have manager or
--  does not have manager along with Manager's name, incase no manager name show null

select E.* , M.Name as ManagerName
from Employees E left join 
Employees M 
on E.ManagerID = M.EmployeeID 


--   Problem 53: Get all employees that have manager or
-- does not have manager along with Manager's name, 
-- incase no manager name the same employee name as manager to himself
select E.*, 
CASE 
	when M.Name is null then E.Name
	else 
		M.Name
END as ManagerName

from Employees E 
left outer join Employees M
on E.ManagerID = M.EmployeeID 


--  Problem 54: Get All Employees managed by 'Mohammed'

select E.*, M.Name  as ManagerName

from Employees E 
left outer join Employees M
on E.ManagerID = M.EmployeeID 
where M.Name = 'Mohammed'

-- Alhamdulelah It Is Done!!!

