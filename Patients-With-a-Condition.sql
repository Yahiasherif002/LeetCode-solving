-- Write your PostgreSQL query statement below
select * 
from Patients
where conditions LIKE 'DIAB1%' OR conditions LIKE '% DIAB1%'