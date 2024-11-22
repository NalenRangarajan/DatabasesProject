CREATE OR ALTER PROCEDURE GameTrack.GetAllGenres

AS

SELECT G.GenreID,G.[Name]
FROM GameTrack.Genre G
