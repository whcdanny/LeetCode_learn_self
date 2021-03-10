# Write your MySQL query statement below
SELECT 
    t.Request_at as Day,
    ROUND(sum(case when t.Status like 'cancelled_%' then 1 else 0 end) / count(*), 2) as 'Cancellation Rate'
FROM Trips t
INNER JOIN Users u
ON t.Client_Id = u.Users_Id
AND u.Banned = 'No'
WHERE t.Request_at BETWEEN '2013-10-01' AND '2013-10-03'
GROUP BY t.Request_at