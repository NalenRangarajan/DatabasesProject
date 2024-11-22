CREATE OR ALTER PROCEDURE GameTrack.GetNumberOfReviewsByUser
	@Username NVARCHAR(128)
AS

SELECT COUNT(DISTINCT R.ReviewID) AS ReviewCount
FROM GameTrack.[Profile] P
	INNER JOIN GameTrack.GameProfile GP ON P.ProfileID = GP.ProfileID
	INNER JOIN GameTrack.Game G ON GP.GameID = G.GameID
	INNER JOIN GameTrack.Review R ON G.ReviewID = R.ReviewID;
