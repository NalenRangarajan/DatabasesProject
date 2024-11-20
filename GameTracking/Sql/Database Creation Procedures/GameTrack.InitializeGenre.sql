CREATE PROCEDURE GameTrack.InitializeGenre
AS
    DECLARE @GenreStaging TABLE
    (
         GenreID TINYINT NOT NULL PRIMARY KEY,
         [Name] VARCHAR(16) NOT NULL
    );


    INSERT INTO @GenreStaging (GenreID, [Name])
    VALUES
        (1, N'Adventure'),
        (2, N'RPG'),
        (3, N'Brawler'),
        (4, N'Indie'),
        (5, N'Turn Based Strategy'),
        (6, N'Platform'),
        (7, N'Simulator'),
        (8, N'Strategy'),
        (9, N'Puzzle'),
        (10, N'Shooter'),
        (11, N'Music'),
        (12, N'Fighting'),
        (13, N'Arcade'),
        (14, N'Visual Novel'),
        (15, N'Card & Board Game'),
        (16, N'Tactical'),
        (17, N'Racing'),
        (18, N'Point-and-Click'),
        (19, N'MOBA'),
        (20, N'Sport'),
        (21, N'Real Time Strategy'),
        (22, N'Quiz/Trivia'),
        (23, N'Other'),
        (24, N'Pinball');

MERGE GameTrack.Genre T
USING @GenreStaging S ON S.GenreID = T.GenreID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(GenreID, [Name])
   VALUES(S.GenreID, S.[Name]);


