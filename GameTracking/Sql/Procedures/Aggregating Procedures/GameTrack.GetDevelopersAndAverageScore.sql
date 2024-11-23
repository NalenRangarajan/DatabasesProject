CREATE OR ALTER PROCEDURE GameTrack.GetDevelopersAndAverageScore
AS
SELECT D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount, CAST(AVG(R.Score) AS DECIMAL(10, 2)) AS AverageReviewScore
FROM GameTrack.Game G
	INNER JOIN GameTrack.GameDeveloper GD ON G.GameID = GD.GameID
	INNER JOIN GameTrack.Developer D ON GD.DeveloperID = D.DeveloperID
	INNER JOIN GameTrack.Review R ON G.GameID = R.GameID
GROUP BY D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount
ORDER BY D.[Name] ASC;

GO