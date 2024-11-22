CREATE OR ALTER PROCEDURE GameTrack.CreatePublisher
	@PublisherName NVARCHAR(32),
	@PublisherID INT OUTPUT
AS

IF NOT EXISTS(
	SELECT * 
	FROM GameTrack.Publisher P 
	WHERE P.[Name] = @PublisherName
	)
BEGIN
	INSERT GameTrack.Publisher([Name])
	VALUES (@PublisherName)
	SET @PublisherID = SCOPE_IDENTITY();
END;
GO