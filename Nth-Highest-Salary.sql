CREATE OR REPLACE FUNCTION NthHighestSalary(N INT) RETURNS TABLE (Salary INT) AS $$
BEGIN
  RETURN QUERY (
    -- Write your PostgreSQL query statement below.
    with highest as(
        select DISTINCT E.salary,
        DENSE_RANK() OVER(ORDER BY E.salary DESC) as rnk
        from Employee E
    )
    select h.salary
    FROM highest h
    where h.rnk=N
    
    UNION ALL
    SELECT NULL
    WHERE NOT EXISTS (SELECT 1 FROM highest WHERE rnk = N)
      
  );
END;
$$ LANGUAGE plpgsql;