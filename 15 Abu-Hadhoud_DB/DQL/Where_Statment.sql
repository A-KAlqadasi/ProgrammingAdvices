
Select * From Employees
where MonthlySalary >500;

Select * From Employees
where MonthlySalary >=500;

Select * From Employees
where not MonthlySalary <=500;

Select * From Employees
where MonthlySalary <500 and Gender ='F';

Select * From Employees
where CountryID =1;


Select * From Employees
where CountryID <>1;

Select * From Employees
where DepartmentID =1 and Gender = 'M';

Select * From Employees
where DepartmentID = 1 and DepartmentID =2;

Select * From Employees
where ExitDate is NULL ; -- with null or not null we use is

Select * From Employees
where ExitDate is Not NULL ;




