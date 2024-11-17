CREATE OR ALTER PROCEDURE GameTrack.GetProfileByUsername
	@Username NVARCHAR(32)
AS

SELECT P.ProfileID, P.Username, P.HashedPassword
FROM GameTrack.Profile P
WHERE P.Username = @Username;
GO