
use HR_Database;

Select A = 5*4, B = 6/2 ;

Select A = 5*4, B = 6/2 
from employees ;

Select ID, FirstName,A = MonthlySalary/2 From Employees;

Select ID , FirstName + ' ' + LastName as FullName 
From Employees;

Select ID, FullName = FirstName + ' ' +LastName
From Employees;

Select ID, FirstName,MonthlySalary, YearlySalary = MonthlySalary *12
From Employees;

select ID,FirstName,MonthlySalary,BounsAmount = BonusPerc * MonthlySalary
From Employees;

Select ID,FirstName +' '+ LastName as FullName , Age = DATEDIFF(YEAR,DateOfBirth,GETDATE()) 
From Employees;

select * from Employees;

-- getdate() is global system function to get the current date
select MyAge = Datediff(Year,'2004-11-03',GETDATE());





