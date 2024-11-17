CREATE OR ALTER PROCEDURE GameTrack.FetchPlatform
	@PlatformID INT
AS

SELECT P.PlatformID, P.Name 
FROM GameTrack.Platform P
WHERE P.PlatformID = @PlatformID;
GO