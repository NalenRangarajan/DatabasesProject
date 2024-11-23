CREATE OR ALTER PROCEDURE GameTrack.GetGamesAndAverageScore
AS
SELECT G.GameID, G.PublisherID, G.[Name], G.ReleaseDate, CAST(AVG(R.Score) AS DECIMAL(10,2)) AS AverageReviewScore
FROM GameTrack.Game G
	INNER JOIN GameTrack.Review R ON G.GameID = R.GameID
GROUP BY G.GameID, G.PublisherID, G.[Name], G.ReleaseDate
ORDER BY AverageReviewScore DESC, G.[Name] ASC;

GO