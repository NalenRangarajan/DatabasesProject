CREATE OR ALTER PROCEDURE GameTrack.CreateGame
   @Name NVARCHAR(32),
   @ReleaseDate DATETIME2,
   @PublisherName NVARCHAR(32),
   @GameID INT OUTPUT
AS

EXEC GameTrack.CreatePublisher @PublisherName = @PublisherName;

DECLARE @PublisherID INT;
SELECT @PublisherID = P.PublisherID
FROM GameTrack.Publisher P
WHERE P.[Name] = @PublisherName;

INSERT GameTrack.Game(PublisherID, [Name], ReleaseDate)
VALUES (@PublisherID, @Name, @ReleaseDate);

SET @GameID = SCOPE_IDENTITY();

GO

