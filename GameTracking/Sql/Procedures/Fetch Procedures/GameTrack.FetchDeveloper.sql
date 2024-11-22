CREATE OR ALTER PROCEDURE GameTrack.FetchDeveloper
	@DeveloperID INT
AS

SELECT D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount
FROM GameTrack.Developer D
WHERE D.DeveloperID = @DeveloperID;
GO