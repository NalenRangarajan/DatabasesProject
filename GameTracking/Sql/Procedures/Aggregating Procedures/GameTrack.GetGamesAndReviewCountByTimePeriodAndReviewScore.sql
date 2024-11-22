CREATE OR ALTER PROCEDURE GameTrack.GetGamesAndReviewCountByTimePeriodAndReviewScore
	@FirstDate DATETIME2,
	@LastDate DATETIME2,
	@MinScore INT,
	@MaxScore INT
AS

SELECT G.GameID, G.[Name], COUNT(DISTINCT R.ReviewID) AS ReviewCount
FROM GameTrack.Game G
	INNER JOIN GameTrack.Review R ON R.GameID = G.GameID
WHERE R.ReviewDate BETWEEN @FirstDate AND @LastDate AND R.Score BETWEEN @MinScore AND @MaxScore
GROUP BY G.GameID, G.[Name]
ORDER BY ReviewCount DESC, G.Name ASC;
GO