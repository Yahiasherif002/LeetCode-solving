WITH daily AS (
  SELECT visited_on, SUM(amount) AS amount
  FROM Customer
  GROUP BY visited_on
),
roll AS (
  SELECT
    visited_on,
    SUM(amount) OVER (
      ORDER BY visited_on
      ROWS BETWEEN 6 PRECEDING AND CURRENT ROW
    ) AS amount_sum,
    AVG(amount) OVER (
      ORDER BY visited_on
      ROWS BETWEEN 6 PRECEDING AND CURRENT ROW
    ) AS avg_sum,
    COUNT(*) OVER (
      ORDER BY visited_on
      ROWS BETWEEN 6 PRECEDING AND CURRENT ROW
    ) AS win_rows
  FROM daily
)
SELECT
  visited_on,
  amount_sum AS amount,
  ROUND(avg_sum, 2) AS average_amount
FROM roll
WHERE win_rows = 7
ORDER BY visited_on;
