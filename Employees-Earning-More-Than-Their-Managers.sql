-- Write your PostgreSQL query statement below
select e1.name as Employee
from Employee e
inner join Employee e1 on e1.managerId=e.id
where  e1.salary>e.salary