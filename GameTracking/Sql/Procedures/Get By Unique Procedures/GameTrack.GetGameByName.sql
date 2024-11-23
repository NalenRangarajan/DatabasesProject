CREATE OR ALTER PROCEDURE GameTrack.GetGameByName
	@Name NVARCHAR(128)
AS

SELECT G.GameID, G.PublisherID, G.[Name], G.ReleaseDate
FROM GameTrack.Game G
WHERE G.[Name] = @Name;
GO