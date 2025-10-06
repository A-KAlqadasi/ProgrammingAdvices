
Select * From Employees;

Select top 5 * from Employees;

-- select top 10 percent of all employees
Select top 10 percent * from Employees;

-- select top 3 largest salaries
select distinct top 3 MonthlySalary From Employees 
order by MonthlySalary Desc ;

-- select all employees has top 3 largest salaries
select distinct ID,FirstName,MonthlySalary From Employees
where MonthlySalary in 
( 
	select distinct top 3 MonthlySalary From Employees 
	order by MonthlySalary desc 
)
order by MonthlySalary desc ;


