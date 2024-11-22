IF OBJECT_ID(N'GameTrack.GameGenre') IS NULL
BEGIN
	CREATE TABLE GameTrack.GameGenre
	(
		GameID INT NOT NULL,
		GenreID INT NOT NULL

		CONSTRAINT [PK_GameTrack_GameGenre_GameID_GenreID] PRIMARY KEY CLUSTERED
		(
			GameID ASC,
            GenreID ASC
		)
	);
END;


/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.GameGenre')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Game')
         AND fk.[name] = N'FK_GameTrack_GameGenre_GameTrack_Game'
   )
BEGIN
   ALTER TABLE GameTrack.GameGenre
   ADD CONSTRAINT [FK_GameTrack_GameGenre_GameTrack_Game] FOREIGN KEY
   (
      GameID
   )
   REFERENCES GameTrack.Game
   (
      GameID
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.GameGenre')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Genre')
         AND fk.[name] = N'FK_GameTrack_GameGenre_GameTrack_Genre'
   )
BEGIN
   ALTER TABLE GameTrack.GameGenre
   ADD CONSTRAINT [FK_GameTrack_GameGenre_GameTrack_Genre] FOREIGN KEY
   (
      GenreID
   )
   REFERENCES GameTrack.Genre
   (
      GenreID
   );
END;