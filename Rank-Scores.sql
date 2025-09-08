-- Write your PostgreSQL query statement below
with ranked as (
    select s.score,
    DENSE_RANK() OVER (ORDER BY s.score desc) as rnk
    from Scores s
)
select r.score,r.rnk as rank
from ranked r
