CREATE OR ALTER PROCEDURE GameTrack.CreateGame
   @Name NVARCHAR(32),
   @ReleaseDate DATETIME2,
   @DeveloperName NVARCHAR(32),
   @PublisherName NVARCHAR(32),
   @GameID INT OUTPUT,
   @PublisherID INT OUTPUT
AS

EXEC GameTrack.CreateDeveloper @DeveloperName = @DeveloperName;

EXEC GameTrack.CreatePublisher @PublisherName = @PublisherName;

SELECT @PublisherID = P.PublisherID
FROM GameTrack.Publisher P
WHERE P.[Name] = @PublisherName;

INSERT GameTrack.Game(PublisherID, [Name], ReleaseDate)
VALUES (@PublisherID, @Name, @ReleaseDate);

SET @GameID = SCOPE_IDENTITY();

GO

