
Select ID, FirstName,MonthlySalary
From Employees
Where DepartmentID =1 ;

--Order ASC by default
Select ID, FirstName,MonthlySalary
From Employees
Where DepartmentID =1 
Order By FirstName;

Select ID, FirstName,MonthlySalary
From Employees
Where DepartmentID =1 
Order By FirstName ASC;

-- Order DESC
Select ID, FirstName,MonthlySalary
From Employees
Where DepartmentID =1 
Order By FirstName Desc;

Select ID, FirstName,MonthlySalary
From Employees
Where DepartmentID =1 
Order By MonthlySalary ASC;

Select ID, FirstName,MonthlySalary
From Employees
Where DepartmentID =1 
Order By MonthlySalary DESC;

Select ID, FirstName,MonthlySalary
From Employees
Where DepartmentID =1 
Order By FirstName, MonthlySalary ;

Select ID, FirstName,MonthlySalary
From Employees
Where DepartmentID =1 
Order By FirstName ASC, MonthlySalary Desc;




