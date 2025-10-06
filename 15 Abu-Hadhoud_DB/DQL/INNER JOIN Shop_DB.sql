
-- INNER JOIN equals JOIN 
SELECT Customers.CustomerID ,Customers.Name,Orders.Amount
FROM Customers 
Join Orders 
ON Customers.CustomerID = Orders.CustomerID ;

------------------------------

SELECT Customers.CustomerID , Customers.Name,Orders.Amount
From Customers
iNNer JOIN Orders
on Customers.CustomerID = Orders.CustomerID;



