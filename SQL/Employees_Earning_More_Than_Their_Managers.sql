SELECT name as Employee
FROM Employee e
WHERE EXISTS(
    SELECT *
    FROM Employee m
    WHERE e.managerId = m.id and e.salary > m.salary
)