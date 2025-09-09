-- Write your PostgreSQL query statement below
WITH ValidTrips AS (
    SELECT 
        t.id,
        t.request_at,
        t.status
    FROM Trips t
    JOIN Users c 
        ON t.client_id = c.users_id AND c.banned = 'No'
    JOIN Users d 
        ON t.driver_id = d.users_id AND d.banned = 'No'
    WHERE t.request_at BETWEEN '2013-10-01' AND '2013-10-03'
),
DailyStats AS (
    SELECT
        request_at AS Day,
        COUNT(*) AS total_trips,
        SUM(CASE WHEN status IN ('cancelled_by_driver', 'cancelled_by_client') THEN 1 ELSE 0 END) AS cancelled_trips
    FROM ValidTrips
    GROUP BY request_at
)
SELECT
    Day,
    ROUND(cancelled_trips * 1.0 / total_trips, 2) AS "Cancellation Rate"
FROM DailyStats;
