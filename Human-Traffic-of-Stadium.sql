-- Write your PostgreSQL query statement below
with ranked as (
    select id, visit_date,people,
    id-row_number() over (order by id) as grp
    from Stadium
    where people >= 100
),
groups as (
    select grp , count(*) as streak
    from ranked
    group by grp
    having count(*) >= 3
)

select r.id, r.visit_date,r.people
from ranked r
join groups g on r.grp=g.grp
order by r.visit_date    