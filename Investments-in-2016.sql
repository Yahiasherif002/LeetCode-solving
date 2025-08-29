with tiv2015 as(
    select  tiv_2015 
    from Insurance
    group by (tiv_2015)
    having count(*)>1
),
Ulocation as (
    select lat,lon
    from Insurance
    group by lat, lon
    having count(*)=1
)

select round(sum(i.tiv_2016)::numeric,2) as tiv_2016
from Insurance as i
 join tiv2015 t on i.tiv_2015=t.tiv_2015
 join Ulocation u on  i.lat = u.lat AND i.lon = u.lon;
