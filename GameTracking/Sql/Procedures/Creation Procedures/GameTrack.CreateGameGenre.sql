CREATE OR ALTER PROCEDURE GameTrack.CreateGameGenre
	@GameID INT,
	@GenreName NVARCHAR(32)
AS

DECLARE @GenreID INT;
SELECT @GenreID = G.GenreID
FROM GameTrack.Genre G
WHERE G.[Name] = @GenreName;

IF NOT EXISTS (
	SELECT *
	FROM GameTrack.GameGenre GG
	WHERE GG.GameID = @GameID AND GG.GenreID = @GenreID
	)
BEGIN
    INSERT INTO GameTrack.GameGenre (GameID, GenreID)
    VALUES (@GameID, @GenreID);
END