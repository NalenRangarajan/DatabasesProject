CREATE OR ALTER PROCEDURE GameTrack.GetDeveloperByName
	@Name NVARCHAR(32)
AS

SELECT D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount
FROM GameTrack.Developer D
WHERE D.Name = @Name;
GO