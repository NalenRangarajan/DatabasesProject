CREATE OR ALTER PROCEDURE GameTrack.GetGamesAndReviewCount
AS
SELECT G.GameID, G.PublisherID, G.[Name], G.ReleaseDate, COUNT(DISTINCT R.ReviewID) AS ReviewCount
FROM GameTrack.Game G
	INNER JOIN GameTrack.Review R ON G.GameID = R.GameID
GROUP BY G.GameID, G.PublisherID, G.[Name], G.ReleaseDate
ORDER BY ReviewCount DESC, G.[Name] ASC;
GO
