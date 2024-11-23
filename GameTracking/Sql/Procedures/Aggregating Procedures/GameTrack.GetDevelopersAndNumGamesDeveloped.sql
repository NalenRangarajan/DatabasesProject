CREATE OR ALTER PROCEDURE GameTrack.GetDevelopersAndNumGamesDeveloped
AS
SELECT D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount, COUNT(G.GameID) AS GamesDeveloped
FROM GameTrack.Game G
	INNER JOIN GameTrack.GameDeveloper GD ON G.GameID = GD.GameID
	INNER JOIN GameTrack.Developer D ON GD.DeveloperID = D.DeveloperID
GROUP BY D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount
ORDER BY D.[Name] ASC;
GO