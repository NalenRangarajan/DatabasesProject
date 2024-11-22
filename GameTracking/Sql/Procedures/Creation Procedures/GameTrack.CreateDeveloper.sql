CREATE OR ALTER PROCEDURE GameTrack.CreateDeveloper
	@DeveloperName NVARCHAR(32),
	@DeveloperID INT OUTPUT
AS

IF NOT EXISTS(
	SELECT * 
	FROM GameTrack.Developer D 
	WHERE D.[Name] = @DeveloperName
	)
BEGIN	
	INSERT GameTrack.Developer([Name])
	VALUES (@DeveloperName)
	SET @DeveloperID = SCOPE_IDENTITY();
END;
GO