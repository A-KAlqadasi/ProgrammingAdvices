
Use myDB;
select * from Employees;

-- update 
update Employees
Set Name = 'Abdulkareem Shawqi'
where id = 2;

update Employees 
Set Name ='Abdulkareem Shawqi', Salary = 5000, Gender = 'M',Phone='782422822'
where ID = 2;


Update Employees
Set salary = salary + 200 
where salary <=2000 ;

update Employees 
Set Salary = Salary * 1.1 
where salary <=2200 ;
