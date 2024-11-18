CREATE OR ALTER PROCEDURE GameTrack.CreateOrEditReview
	@GameID INT NOT NULL,
	@Score INT NOT NULL,
	@Body NVARCHAR(512),
	@ReviewID INT OUTPUT
AS

WITH SourceCTE(GameID, Score, Body) AS
	(
		SELECT NLM.GameID, NLM.Score, NLM.Body
		FROM
			(
				VALUES
				(@GameID, @Score, @Body)
			) NLM(GameID, Score, Body)
	)
MERGE GameTrack.Review R
USING SourceCTE S ON R.GameID = S.GameID
WHEN MATCHED
	AND NOT EXISTS
	(
		SELECT R.Score, R.Body
		INTERSECT
		SELECT S.Score, S.Body
	) THEN
	UPDATE
	SET
		Score = S.Score,
		Body = S.Body,
		ReviewDate = SYSDATETIME()
WHEN NOT MATCHED THEN
	INSERT(GameID, Score, Body)
	VALUES(S.GameID, S.Score, S.Body);
GO

