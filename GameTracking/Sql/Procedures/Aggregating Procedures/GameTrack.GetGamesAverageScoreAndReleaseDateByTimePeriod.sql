CREATE OR ALTER PROCEDURE GameTrack.GetGamesAverageScoreAndReleaseDateByTimePeriod
	@FirstDate DATETIME2,
	@LastDate DATETIME2
AS

SELECT G.GameID, G.Name, AVG(R.Score) AS AverageReviewScore, G.ReleaseDate
FROM GameTrack.Game G
JOIN GameTrack.Review R ON R.GameID = G.GameID
WHERE G.ReleaseDate BETWEEN @FirstDate AND @LastDate
GROUP BY G.GameID, G.Name, G.ReleaseDate
ORDER BY AverageReviewScore Desc, G.ReleaseDate DESC;
GO