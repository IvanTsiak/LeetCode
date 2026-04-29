SELECT f.id
FROM Weather f, Weather s
WHERE DATEDIFF(f.recordDate, s.recordDate) = 1 and f.temperature > s.temperature