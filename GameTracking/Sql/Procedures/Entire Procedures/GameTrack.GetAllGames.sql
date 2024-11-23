CREATE OR ALTER PROCEDURE GameTrack.GetAllGames

AS

SELECT G.GameID, G.PublisherID, G.[Name], G.ReleaseDate
FROM GameTrack.Game G
ORDER BY G.[Name] ASC;
