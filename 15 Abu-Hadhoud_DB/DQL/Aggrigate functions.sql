
Use HR_Database;

select TotalCount= COUNT(MonthlySalary),
		TotalSum= Sum(MonthlySalary),
		Average= AVG(MonthlySalary),
		MinSalary= MIN(MonthlySalary),
		MaxSalary= MAX(MonthlySalary)
From Employees;



select TotalCount= COUNT(MonthlySalary),
		TotalSum= Sum(MonthlySalary),
		Average= AVG(MonthlySalary),
		MinSalary= MIN(MonthlySalary),
		MaxSalary= MAX(MonthlySalary)
From Employees where DepartmentID = 7;


select * from Employees;
--AVG(), COUNT() only the not null fields 
-- 
select TotalEmployees=Count(ID) From Employees;

Select ResignedEmployees= Count(ExitDate) 
From Employees;

--------------------------------------------------
--------------------------------------------------


