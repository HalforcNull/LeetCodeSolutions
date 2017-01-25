-- Write your MySQL query statement below
Select p.FirstName, p.LastName, a.City, a.State from 
Person p Left Join Address a on p.PersonId = a.PersonId