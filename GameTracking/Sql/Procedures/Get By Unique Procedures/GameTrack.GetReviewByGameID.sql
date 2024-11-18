CREATE OR ALTER PROCEDURE GameTrack.GetReviewByGameID
	@GameID INT
AS

SELECT R.ReviewID, R.GameID, R.Score, ISNULL(R.Body, N''), R.ReviewDate
FROM GameTrack.Review R
WHERE R.GameID = @GameID;
GO