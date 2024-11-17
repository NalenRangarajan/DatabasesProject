CREATE OR ALTER PROCEDURE GameTrack.GetCriticByWebsite
	@Website NVARCHAR(128)
AS

SELECT C.CriticID, C.Website, C.FirstName, C.LastName
FROM GameTrack.Critic C
WHERE C.Website = @Website;
GO