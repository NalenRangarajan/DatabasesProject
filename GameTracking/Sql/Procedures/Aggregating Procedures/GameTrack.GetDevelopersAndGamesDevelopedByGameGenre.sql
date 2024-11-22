CREATE OR ALTER PROCEDURE GameTrack.GetDevelopersAndGamesDevelopedByGameGenre
	@SelectedGenre NVARCHAR(32)
AS

SELECT D.DeveloperID, D.[Name], COUNT(G.GameID) AS GamesDeveloped
FROM GameTrack.Game G
	INNER JOIN GameTrack.GameDeveloper GD ON G.GameID = GD.GameID
	INNER JOIN GameTrack.Developer D ON GD.DeveloperID = D.DeveloperID
	INNER JOIN GameTrack.GameGenre GG ON G.GameID = GG.GameID
	INNER JOIN GameTrack.Genre Genre ON GG.GenreID = Genre.GenreID
WHERE Genre.[Name] = @SelectedGenre
GROUP BY D.DeveloperID, D.[Name]
ORDER BY GamesDeveloped DESC;
GO
