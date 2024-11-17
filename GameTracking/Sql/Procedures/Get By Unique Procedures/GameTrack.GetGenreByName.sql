CREATE OR ALTER PROCEDURE GameTrack.FetchGenre
	@Name NVARCHAR(16)
AS

SELECT G.GenreID, P.[Name] 
FROM GameTrack.Genre G
WHERE G.[Name] = @Name;
GO
