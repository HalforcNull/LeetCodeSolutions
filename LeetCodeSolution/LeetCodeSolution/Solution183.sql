Select Name as Customers from Customers where Id not in (
Select CustomerID from Orders)