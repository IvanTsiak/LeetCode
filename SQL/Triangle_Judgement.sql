SELECT *,
       CASE
           WHEN x+y>z and x+z>y and z+y>x THEN 'Yes'
           ELSE 'No'
       END AS triangle
FROM Triangle