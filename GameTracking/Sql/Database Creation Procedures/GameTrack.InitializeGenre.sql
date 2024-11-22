
    DECLARE @GenreStaging TABLE
    (
        GenreID INT NOT NULL IDENTITY(1,1),
        [Name] VARCHAR(32) NOT NULL
    );


    INSERT INTO @GenreStaging ([Name])
    VALUES
        (N'Adventure'),
        (N'RPG'),
        (N'Brawler'),
        (N'Indie'),
        (N'Turn Based Strategy'),
        (N'Platform'),
        (N'Simulator'),
        (N'Strategy'),
        (N'Puzzle'),
        (N'Shooter'),
        (N'Music'),
        (N'Fighting'),
        (N'Arcade'),
        (N'Visual Novel'),
        (N'Card & Board Game'),
        (N'Tactical'),
        (N'Racing'),
        (N'Point-and-Click'),
        (N'MOBA'),
        (N'Sport'),
        (N'Real Time Strategy'),
        (N'Quiz/Trivia'),
        (N'Other'),
        (N'Pinball');

MERGE GameTrack.Genre T
USING @GenreStaging S ON S.GenreID = T.GenreID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name])
   VALUES(S.[Name]);


