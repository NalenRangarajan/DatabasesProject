CREATE OR ALTER PROCEDURE GameTrack.GetDeveloperByEmail
	@Email NVARCHAR(128)
AS

SELECT D.DeveloperID, D.[Name], D.Email, D.FoundedDate, D.[Location], D.TeamCount
FROM GameTrack.Developer D
WHERE D.Email = @Email;
GO