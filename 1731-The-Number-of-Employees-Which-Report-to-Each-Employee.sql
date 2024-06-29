SELECT m.employee_id,m.name,count(e.employee_id) as reports_count ,
 ROUND(AVG(e.age)) as average_age
 FROM employees e join employees m 
 on e.reports_to = m.employee_id
 group by m.employee_id,m.name
 order by m.employee_id
