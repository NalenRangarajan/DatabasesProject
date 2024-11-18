CREATE OR ALTER PROCEDURE GameTrack.CreateGamePlatform
	@GameID INT,
	@PlatformName NVARCHAR(32)
AS

DECLARE @PlatformID TINYINT;
SELECT @PlatformID = P.PlatformID
FROM GameTrack.[Platform] P
WHERE P.[Name] = @PlatformName;

IF NOT EXISTS (
	SELECT *
	FROM GameTrack.GamePlatform GP
	WHERE GP.GameID = @GameID AND GP.PlatformID = @PlatformID
	)
BEGIN
    INSERT INTO GameTrack.GamePlatform (GameID, PlatformID)
    VALUES (@GameID, @PlatformID);
END