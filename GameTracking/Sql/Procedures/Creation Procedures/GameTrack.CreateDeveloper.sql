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
		DECLARE @NewDevEmail NVARCHAR(128) = @DeveloperName + N'@gmail.com';

		INSERT GameTrack.Developer([Name], Email)
		VALUES (@DeveloperName, @NewDevEmail)
		SET @DeveloperID = SCOPE_IDENTITY();
	END;
ELSE
	BEGIN
		SELECT @DeveloperID = D.DeveloperID
		FROM GameTrack.Developer D 
		WHERE D.[Name] = @DeveloperName
	END;
GO
