CREATE OR ALTER PROCEDURE GameTrack.GetGenresForGame
	@GameID INT
AS

SELECT Genre.GenreID, Genre.[Name]
FROM GameTrack.Game G
	INNER JOIN GameTrack.GameGenre GG ON G.GameID = GG.GameID
	INNER JOIN GameTrack.Genre Genre ON GG.GenreID = Genre.GenreID
WHERE G.GameID = @GameID;
GO