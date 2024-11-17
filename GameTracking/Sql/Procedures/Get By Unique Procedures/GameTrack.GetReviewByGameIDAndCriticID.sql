CREATE OR ALTER PROCEDURE GameTrack.GetReviewByGameIDAndCriticID
	@GameID INT
	@CriticID INT
AS

SELECT R.ReviewID, R.GameID, R.CriticID, R.Score, ISNULL(R.Title, N''), ISNULL(R.Body, N''), R.ReviewDate
FROM GameTrack.Review R
WHERE R.GameID = @GameID AND R.CriticID = @CriticID;
GO