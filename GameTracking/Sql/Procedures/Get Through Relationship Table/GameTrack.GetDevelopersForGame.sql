CREATE OR ALTER PROCEDURE GameTrack.GetDevelopersForGame
	@GameID INT
AS

SELECT D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount
FROM GameTrack.Game G
	INNER JOIN GameTrack.GameDeveloper GD ON G.GameID = GD.GameID
	INNER JOIN GameTrack.Developer D ON GD.DeveloperID = D.DeveloperID
WHERE G.GameID = @GameID;
GO