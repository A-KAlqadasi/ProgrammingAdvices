use Shop_Database;

-- if the select inside the exists statment returns at least one row
-- the conditions before the exists will execute
--The EXISTS operator is used to test for the existence of any record in a subquery.
--The EXISTS operator returns TRUE if the subquery returns one or more records.

select X= 'Yes'
where exists
	(
	   select * from Orders
	   where CustomerID=3 and Amount < 600
	)

-- 
select X= 'Yes'
where exists
	(
	   select * from Orders
	   where CustomerID=3 and Amount < 300
	)

	-----------------------------------

	select * from Customers T1
	where 
		exists 
		(
			select * from Orders 
			where CustomerID = T1.CustomerID and Amount < 600
		)
-----------------------------------

	select * from Customers T1
	where 
		exists 
		(
			select top 1 R='Y' from Orders 
			where CustomerID = T1.CustomerID and Amount < 600
		) 

-------------------------------------




