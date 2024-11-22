CREATE OR ALTER PROCEDURE GameTrack.GetDevelopersAndGamesDeveloped
	@AverageScore Decimal(2,1) OUTPUT
AS
SELECT D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount, AVG(R.Score) AS AverageReviewScore
FROM GameTrack.Game G
	INNER JOIN GameTrack.GameDeveloper GD ON G.GameID = GD.GameID
	INNER JOIN GameTrack.Developer D ON GD.DeveloperID = D.DeveloperID
GROUP BY D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount
ORDER BY D.[Name] DESC;

SET @NumDeveloped = GamesDeveloped;
GO