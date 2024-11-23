CREATE OR ALTER PROCEDURE GameTrack.GetGamesAndAverageScore
AS
SELECT G.GameID, G.PublisherID, G.[Name], G.ReleaseDate, AVG(R.Score) AS AverageReviewScore
FROM GameTrack.Game G
	INNER JOIN GameTrack.Review R ON G.GameID = R.GameID
GROUP BY G.GameID, G.PublisherID, G.[Name], G.ReleaseDate
ORDER BY AverageReviewScore DESC, G.[Name] ASC;

SET @AverageScore = AverageReviewScore;
GO