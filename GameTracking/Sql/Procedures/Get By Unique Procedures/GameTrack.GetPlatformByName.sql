CREATE OR ALTER PROCEDURE GameTrack.GetPlatformByName
	@Name NVARCHAR(32)
AS

SELECT P.PlatformID, P.[Name] 
FROM GameTrack.[Platform] P
WHERE P.[Name] = @Name;
GO