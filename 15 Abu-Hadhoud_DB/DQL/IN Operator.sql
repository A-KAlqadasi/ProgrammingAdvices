

Select * From Employees
where DepartmentID = 1 Or DepartmentID =2 or DepartmentID = 7;

-- IN is shortcut for multiple or statments
Select * From Employees 
where DepartmentID In (1,2,7);

Select * From Employees
where FirstName in ('Jachb','Brooks','Harper');


Select  Departments.Name From Departments
where ID in (Select DepartmentID From Employees where MonthlySalary <210);

Select  Departments.Name From Departments
where ID not in (Select DepartmentID From Employees where MonthlySalary <210);

Select * From Employees;

-- select countries names that thier employees has salary less than 210
Select Countries.Name From Countries
where ID in (Select CountryID From Employees where MonthlySalary <210)

-- select countries names that thier employees has not salary less than 210
Select Countries.Name From Countries
where ID not in (Select CountryID From Employees where MonthlySalary <210)

