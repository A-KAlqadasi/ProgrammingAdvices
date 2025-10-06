Use HR_Database;
-- NEWID() is GUID which is Global Unique Identifier 
-- it is 128 bit number that implossible to be repeated in the world
select top 10 NEWID(), * from Employees
order by NEWID();
