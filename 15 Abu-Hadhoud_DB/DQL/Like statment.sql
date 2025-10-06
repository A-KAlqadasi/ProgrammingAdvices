

select *  from Employees;

-- Finds any values that start with "a"
select ID,FirstName 
From Employees
where FirstName like 'a%' ;

-- Finds any values that ends with "a"
select ID,FirstName 
From Employees
where FirstName like '%a' ;

-- Finds any values that have "tell" in any position
select ID,FirstName 
From Employees
where FirstName like '%tell%' ;

-- Finds any values that starts with "a" and ends with "a"
select ID,FirstName 
From Employees
where FirstName like 'a%a' ;

-- Finds any values that have "a" in the second position
select ID,FirstName 
From Employees
where FirstName like '_a%' ;

-- Finds any values that have "a" in the third position
select ID,FirstName 
From Employees
where FirstName like '__a%' ;

-- Finds any values that starts with "a" and are at least 3 charaters in length
select ID,FirstName 
From Employees
where FirstName like 'a__%' ;

-- Finds any values that start with "a" or "b"
select ID,FirstName 
From Employees
where FirstName like 'a%' or FirstName like 'b%' ;