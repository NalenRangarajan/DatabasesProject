CREATE OR ALTER PROCEDURE GameTrack.GetPercentPositiveReviewsForGame
	@GameID INT
AS

SELECT COUNT(DISTINCT R.ReviewID) / COUNT(*) AS PositivePercent
FROM GameTrack.Game G 
	INNER JOIN GameTrack.Review R ON G.ReviewID = R.ReviewID
WHERE
