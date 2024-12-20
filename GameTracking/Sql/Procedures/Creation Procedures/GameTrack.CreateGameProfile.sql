﻿CREATE OR ALTER PROCEDURE GameTrack.CreateGameProfile
	@GameID INT,
	@Username NVARCHAR(32)
AS

DECLARE @ProfileID INT;
SELECT @ProfileID = P.ProfileID
FROM GameTrack.[Profile] P
WHERE P.Username = @Username;

IF NOT EXISTS (
	SELECT *
	FROM GameTrack.GameProfile GP
	WHERE GP.GameID = @GameID AND GP.ProfileID = @ProfileID
	)
BEGIN
    INSERT INTO GameTrack.GameProfile (GameID, ProfileID)
    VALUES (@GameID, @ProfileID);
END