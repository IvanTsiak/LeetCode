DELETE FROM Person
WHERE Id IN (
    SELECT Id
    FROM (SELECT Id
          FROM Person l
          WHERE Id NOT IN (
              SELECT MIN(Id)
              FROM Person k
              WHERE l.Email = k.Email
              )) temp
)