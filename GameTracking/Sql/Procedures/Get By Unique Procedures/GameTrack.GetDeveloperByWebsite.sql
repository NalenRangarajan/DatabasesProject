REATE OR ALTER PROCEDURE GameTrack.GetDeveloperByWebsite
	@Website NVARCHAR(128)
AS

SELECT D.DeveloperID, D.Name, D.Website, D.FoundedDate, D.Location, D.TeamCount
FROM GameTrack.Developer D
WHERE D.Website = @Website;
GO