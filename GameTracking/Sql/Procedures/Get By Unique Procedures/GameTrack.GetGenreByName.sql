CREATE OR ALTER PROCEDURE GameTrack.GetGenreByName
	@Name NVARCHAR(16)
AS

SELECT G.GenreID, G.[Name] 
FROM GameTrack.Genre G
WHERE G.[Name] = @Name;
GO
