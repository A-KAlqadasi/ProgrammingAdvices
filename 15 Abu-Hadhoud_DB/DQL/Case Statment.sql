/*
The CASE expression goes through conditions and returns a value when 
the first condition is met (like an if-then-else statement). 
So, once a condition is true, it will stop reading and return the result. 
If no conditions are true, it returns the value in the ELSE clause.
If there is no ELSE part and no conditions are true, it returns NULL.

*/

Use HR_Database;

Select ID, FirstName, LastName, GenderTitle=
Case 
	when Gender='M' Then 'Male'
	When Gender='F' Then 'Female'
	Else 'Unknow'
End

From Employees;

--------------------------------------------

Select ID, FirstName, LastName, 
GenderTitle =
Case 
	When Gender='M' Then 'Male'
	When Gender='F' Then 'Female'
End ,
EmployeeStatus=
Case
	When ExitDate is NULL Then 'Active'
	When ExitDate is Not NULL Then 'Resigned'
End

From Employees;
----------------------------------------


Select ID, FirstName, LastName, MonthlySalary,

NewSalaryToBe =
Case
	When Gender ='M' Then MonthlySalary * 1.1
	when Gender='F' Then MonthlySalary * 1.15
End
From Employees;




