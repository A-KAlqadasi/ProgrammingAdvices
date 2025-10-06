

Update Employees
Set FirstName = 'Mohammed', LastName = 'Abu-Hadhoud'
where ID = 285;

Update Employees
Set FirstName = 'Mohammad',LastName='Basheer'
where ID= 286 ;

-- normal search for name that have the most same letters
Select ID, FirstName ,LastName
From Employees
where FirstName like 'Mohammed' or FirstName like 'Mohammad';

-- search like the previous using wild card 
Select Id,FirstName,LastName
From Employees 
where FirstName like 'Mohamm[ae]d';

-----------------------------------------
-- you can use not
Select Id,FirstName,LastName
From Employees 
where FirstName NOT like 'Mohamm[ae]d';

------------------------

select ID,FirstName,LastName
from Employees
where FirstName like 'a%' or FirstName like 'b%' or FirstName like 'c%'

-- search for all employees that thier first name start with a or b or c
Select Id,FirstName,LastName
From Employees 
where FirstName like '[abc]%' ;

-- search for all employees that thier first name doesn't start with a or b or c
Select Id,FirstName,LastName
From Employees 
where FirstName like '[^abc]%' ;

----------------------------------------------------
-- search for all employees that thire first name start from letters a to l
Select Id,FirstName,LastName
From Employees 
where FirstName like '[a-l]%' ;




