CREATE OR ALTER PROCEDURE GameTrack.SearchingDevelopers
	@PartialDeveloperName NVARCHAR(64),
	@StartDate DATETIME2,
	@EndDate DATETIME2,
	@MinScore INT,
	@MaxScore INT,
	@Genres NVARCHAR(128)
AS

SELECT G.GameID, G.PublisherID, G.[Name], G.ReleaseDate, AVG(R.Score) AS AverageScore
FROM GameTrack.Game G
	INNER JOIN GameTrack.GameDeveloper GD ON G.GameID = GD.GameID
	INNER JOIN GameTrack.Developer D ON GD.DeveloperID = D.DeveloperID
	INNER JOIN GameTrack.Review R ON G.GameID = R.GameID
	INNER JOIN GameTrack.GameGenre GG ON G.GameID = GG.GameID
	INNER JOIN GameTrack.Genre Ge ON GG.GenreID = Ge.GenreID
WHERE (@PartialDeveloperName IS NULL OR D.[Name] LIKE @PartialDeveloperName + N'%')
	AND (@StartDate IS NULL OR @StartDate <= G.ReleaseDate)
	AND (@EndDate IS NULL OR @EndDate >= G.ReleaseDate)
	AND (@Genres IS NULL OR @Genres = '' OR EXISTS (
		SELECT *
		FROM STRING_SPLIT(@Genres, ',') AS genre
		WHERE genre.value = Ge.[Name]
		))
GROUP BY G.GameID, G.PublisherID, G.[Name], G.ReleaseDate
HAVING (@MinScore IS NULL OR @MinScore <= AVG(R.Score))
	AND (@MaxScore IS NULL OR @MaxScore >= AVG(R.Score))
ORDER BY G.[Name] ASC, G.ReleaseDate DESC;
GO


