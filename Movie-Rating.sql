WITH UserCounts as (
    SELECT u.name , count(*) as cnt
    FROM MovieRating mr 
    join users u on u.user_id = mr.user_id
    group by u.name 
),
TopUser as (
    select name 
    from UserCounts
    order by cnt desc , name asc
    limit 1
),
MovieRatings as (
    SELECT m.title , AVG(mr.rating) as avg_rating 
    from MovieRating mr 
    join Movies m on m.movie_id = mr.movie_id
    WHERE mr.created_at BETWEEN '2020-02-01' AND '2020-02-29'
    group by m.title
),
TopMovie as (
    select title 
    from MovieRatings
    order by  avg_rating desc , title asc 
    limit 1
)

select name as results from TopUser
union all
select title as results from TopMovie

