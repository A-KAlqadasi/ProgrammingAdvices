

select TotalCount= COUNT(MonthlySalary),
		TotalSum= Sum(MonthlySalary),
		Average= AVG(MonthlySalary),
		MinSalary= MIN(MonthlySalary),
		MaxSalary= MAX(MonthlySalary)
From Employees;

--  sum , avg,min,max aggrigate functions in each country
select CountryID, TotalCount= COUNT(MonthlySalary),
		TotalSum= Sum(MonthlySalary),
		Average= AVG(MonthlySalary),
		MinSalary= MIN(MonthlySalary),
		MaxSalary= MAX(MonthlySalary)
From Employees
Group by CountryID
Order by CountryID;

----  sum , avg,min,max aggrigate functions in each department
select DepartmentID, TotalCount= COUNT(MonthlySalary),
		TotalSum= Sum(MonthlySalary),
		Average= AVG(MonthlySalary),
		MinSalary= MIN(MonthlySalary),
		MaxSalary= MAX(MonthlySalary)
From Employees
Group by DepartmentID
Order by DepartmentID;

select DepartmentID , TotalCount= COUNT(MonthlySalary),
		TotalSum= Sum(MonthlySalary),
		Average= AVG(MonthlySalary),
		MinSalary= MIN(MonthlySalary),
		MaxSalary= MAX(MonthlySalary)
From Employees
where DepartmentID = 4
Group by DepartmentID
Order by DepartmentID;






