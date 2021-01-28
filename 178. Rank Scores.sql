# Write your MySQL query statement below
Select Score, (select count(distinct Score) from Scores where Score >= s.Score ) 'Rank' from Scores s ORDER BY Score DESC;