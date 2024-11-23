CREATE OR ALTER PROCEDURE GameTrack.CreateGame
   @Name NVARCHAR(32),
   @ReleaseDate DATETIME2,
   @DeveloperName NVARCHAR(32),
   @PublisherName NVARCHAR(32),
   @GenreID INT,
   @GameID INT OUTPUT,
   @PublisherID INT OUTPUT
AS

DECLARE @DeveloperID INT;

EXEC GameTrack.CreateDeveloper @DeveloperName = @DeveloperName, @DeveloperID = @DeveloperID OUTPUT;

EXEC GameTrack.CreatePublisher @PublisherName = @PublisherName, @PublisherID = @PublisherID OUTPUT;

INSERT GameTrack.Game(PublisherID, [Name], ReleaseDate)
VALUES (@PublisherID, @Name, @ReleaseDate);

SET @GameID = SCOPE_IDENTITY();

INSERT GameTrack.GameDeveloper(GameID,DeveloperID)
VALUES(@GameID, @DeveloperID);

--add gamegenre

INSERT GameTrack.GameGenre(GameID,GenreID)
VALUES(@GameID, @GenreID);


GO

