CREATE OR ALTER PROCEDURE GameTrack.CreatePublisher
	@PublisherName NVARCHAR(32)
AS

IF NOT EXISTS(
	SELECT * 
	FROM GameTrack.Publisher P 
	WHERE P.[Name] = @PublisherName
	)
BEGIN
	INSERT GameTrack.Publisher([Name])
	VALUES (@PublisherName)
END;
GO