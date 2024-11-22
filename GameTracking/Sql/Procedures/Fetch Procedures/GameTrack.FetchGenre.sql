CREATE OR ALTER PROCEDURE GameTrack.FetchGenre
	@GenreID INT
AS

SELECT G.GenreID, G.[Name] 
FROM GameTrack.Genre G
WHERE G.GenreID = @GenreID;
GO