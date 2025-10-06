

------------------------------
--left join and left outer join are the same.

--left Join: gets all data fro mtable customers and only matched data from orders

select Customers.CustomerID , Customers.Name,Orders.Amount
From Customers
LEFT JOIN Orders 
ON (Customers.CustomerID = Orders.CustomerID) ;


select Customers.CustomerID , Customers.Name,Orders.Amount
From Customers
LEFT OUTER JOIN Orders 
ON (Customers.CustomerID = Orders.CustomerID) ;
