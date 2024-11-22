CREATE OR ALTER PROCEDURE GameTrack.GetNumberOfReviewsForGame
	@GameID INT
AS

SELECT COUNT(DISTINCT R.ReviewID) AS ReviewCount
FROM GameTrack.Game G 
	INNER JOIN GameTrack.Review R ON G.ReviewID = R.ReviewID;
