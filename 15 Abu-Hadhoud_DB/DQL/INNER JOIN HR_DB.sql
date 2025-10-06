-- INNER JOIN is the same as JOIN 
Select Employees.ID,Employees.FirstName,Employees.LastName,Departments.Name 'DeptName'
From Employees
INNER JOIN Departments
ON Employees.DepartmentID = Departments.ID;

------------------

SELECT Employees.ID, Employees.FirstName, Employees.LastName, Departments.Name as DeptName
FROM     Employees INNER JOIN
                  Departments ON (Employees.DepartmentID = Departments.ID)
where Departments.Name = 'IT'

-----------------------------
-- join between three tables employees , departments and countries 
SELECT Employees.ID, Employees.FirstName, Employees.LastName, Departments.Name as DeptName,Countries.Name as Country
FROM     Employees INNER JOIN
                  Departments ON (Employees.DepartmentID = Departments.ID)
				  INNER JOIN Countries ON (Employees.CountryID = Countries.ID) ;
				  
----------------------------------

SELECT Employees.ID, Employees.FirstName, Employees.LastName, Departments.Name as DeptName,Countries.Name as Country
FROM     Employees INNER JOIN
                  Departments ON (Employees.DepartmentID = Departments.ID)
				  INNER JOIN Countries ON (Employees.CountryID = Countries.ID) 
WHERE Countries.Name = 'CHINA';
