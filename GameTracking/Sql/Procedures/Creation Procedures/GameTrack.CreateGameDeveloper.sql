CREATE OR ALTER PROCEDURE GameTrack.CreateGameDeveloper
	@GameID INT,
	@DeveloperName NVARCHAR(32)
AS

DECLARE @DeveloperID INT;
SELECT @DeveloperID = D.DeveloperID
FROM GameTrack.Developer D
WHERE D.[Name] = @DeveloperName;

IF NOT EXISTS (
	SELECT *
	FROM GameTrack.GameDeveloper GD
	WHERE GD.GameID = @GameID AND GD.DeveloperID = @DeveloperID
	)
BEGIN
    INSERT INTO GameTrack.GameDeveloper (GameID, DeveloperID)
    VALUES (@GameID, @DeveloperID);
END