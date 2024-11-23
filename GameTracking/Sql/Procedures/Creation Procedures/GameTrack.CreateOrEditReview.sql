CREATE OR ALTER PROCEDURE GameTrack.CreateOrEditReview
	@GameID INT,
	@Score DECIMAL(10,2),
	@Body NVARCHAR(512),
	@ReviewID INT OUTPUT
AS

DECLARE @ExistingReviewID INT;

SELECT @ExistingReviewID = ReviewID
FROM GameTrack.Review
WHERE GameID = @GameID;

IF @ExistingReviewID IS NOT NULL
	BEGIN
		UPDATE GameTrack.Review
		SET
			Score = @Score,
			Body = @Body,
			ReviewDate = SYSDATETIME()
		WHERE ReviewID = @ExistingReviewID;
		SET @ReviewID = @ExistingReviewID;
	END
ELSE
	BEGIN
		INSERT GameTrack.Review (GameID, Score, Body)
		VALUES(@GameID, @Score, @Body)
		SET @ReviewID = SCOPE_IDENTITY();
	END;
GO

