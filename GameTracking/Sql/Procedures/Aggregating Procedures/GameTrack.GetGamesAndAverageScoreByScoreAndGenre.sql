CREATE OR ALTER PROCEDURE GameTrack.GetGamesAndAverageScoreByScoreAndGenre
	@MinScore INT,
	@MaxScore INT,
	@SelectedGenre NVARCHAR(32)
AS

SELECT G.GameID, G.Name, AVG(R.Score) AS AverageReviewScore
FROM GameTrack.Game G
	INNER JOIN GameTrack.Review R ON G.GameID = R.GameID
WHERE G.Genre = @SelectedGenre
GROUP BY G.GameID, G.Name
HAVING AVG(R.Score) >= @MinScore AND AVG(R.Score) <= @MaxScore
ORDER BY AverageReviewScore DESC, G.Name ASC;
GO