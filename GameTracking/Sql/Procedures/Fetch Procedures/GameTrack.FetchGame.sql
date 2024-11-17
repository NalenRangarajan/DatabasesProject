CREATE OR ALTER PROCEDURE GameTrack.FetchGame
	@GameID INT
AS

SELECT G.GameID, G.PublisherID, G.Name, G.ReleaseDate, G.Genre, G.Platform
FROM GameTrack.Game G
WHERE G.GameID = @GameID;
GO