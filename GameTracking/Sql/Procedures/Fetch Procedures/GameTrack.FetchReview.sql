CREATE OR ALTER PROCEDURE GameTrack.FetchReview
	@ReviewID INT
AS

SELECT R.ReviewID, R.GameID, R.Score,  ISNULL(R.Body, N''), R.ReviewDate
FROM GameTrack.Review R
WHERE R.ReviewID = @ReviewID;
GO