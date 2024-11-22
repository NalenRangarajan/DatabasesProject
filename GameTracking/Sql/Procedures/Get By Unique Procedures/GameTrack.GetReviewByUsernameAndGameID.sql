CREATE OR ALTER PROCEDURE GameTrack.GetReviewByUsernameAndGameID
	@Username NVARCHAR(32),
	@GameID INT
AS

SELECT R.ReviewID, R.GameID, R.Score, R.Body, R.ReviewDate
FROM GameTrack.[Profile] P 
	INNER JOIN GameTrack.GameProfile GP ON P.ProfileID = GP.ProfileID
	INNER JOIN GameTrack.Game G ON GP.GameID = G.GameID
	INNER JOIN Review R ON G.GameID = R.ReviewID
WHERE P.Username = @Username AND G.GameID = @GameID;
GO