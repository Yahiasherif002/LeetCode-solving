with ranked as (
    select id,
        name as Employee,
        salary,
        departmentId,
        dense_rank() over (
            partition by departmentId
            order by salary desc
        ) as salary_rank
        from Employee
)

select d.name as Department ,
        r.Employee,
        r.Salary
from ranked r
join Department d
on r.departmentId = d.id
where r.salary_rank <=3