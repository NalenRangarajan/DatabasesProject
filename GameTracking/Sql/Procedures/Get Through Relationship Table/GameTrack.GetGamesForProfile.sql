CREATE OR ALTER PROCEDURE GameTrack.GetGamesForProfile
	@Username NVARCHAR(32)
AS

SELECT G.GameID, P.ProfileID, P.Username, P.HashedPassword
FROM GameTrack.[Profile] P
	INNER JOIN GameTrack.GameProfile GP ON P.ProfileID = GP.ProfileID
	INNER JOIN GameTrack.Game G ON GP.GameID = G.GameID
WHERE P.Username = @Username;
GO
