-- having is used like where statment on group by for aggrigate functions 
-- we cannot use where statment with aggrigate functions directly

select DepartmentID, TotalCount= COUNT(MonthlySalary),
		TotalSum= Sum(MonthlySalary),
		Average= AVG(MonthlySalary),
		MinSalary= MIN(MonthlySalary),
		MaxSalary= MAX(MonthlySalary)
From Employees
Group by DepartmentID
having Count(MonthlySalary) > 100 
Order by DepartmentID;

-- using where statment with aggrigate functions indirectly
-----**************---------

select * from
(

select DepartmentID, TotalCount= COUNT(MonthlySalary),
		TotalSum= Sum(MonthlySalary),
		Average= AVG(MonthlySalary),
		MinSalary= MIN(MonthlySalary),
		MaxSalary= MAX(MonthlySalary)
From Employees
Group by DepartmentID

)AS R1 
where R1.TotalCount > 100 ;



