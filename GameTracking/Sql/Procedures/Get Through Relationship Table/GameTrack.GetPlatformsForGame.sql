CREATE OR ALTER PROCEDURE GameTrack.GetPlatformsForGame
	@GameID INT
AS

SELECT P.PlatformID, P.[Name]
FROM GameTrack.Game G
	INNER JOIN GameTrack.GamePlatform GP ON G.GameID = GP.GameID
	INNER JOIN GameTrack.[Platform] P ON GP.PlatformID = P.PlatformID
WHERE G.GameID = @GameID;
GO