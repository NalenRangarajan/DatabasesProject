IF OBJECT_ID(N'GameTrack.GameDeveloper') IS NULL
BEGIN
	CREATE TABLE GameTrack.GameDeveloper
	(
		GameID INT NOT NULL IDENTITY(1,1),
		DeveloperID INT NOT NULL IDENTITY(1,1)

		CONSTRAINT [PK_GameTrack_GameDeveloper_GameID_DeveloperID] PRIMARY KEY CLUSTERED
		(
			GameID ASC,
            DeveloperID ASC
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.GameDeveloper')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Game')
         AND fk.[name] = N'FK_GameTrack_GameDeveloper_GameTrack_Game'
   )
BEGIN
   ALTER TABLE GameTrack.GameDeveloper
   ADD CONSTRAINT [FK_GameTrack_GameDeveloper_GameTrack_Game] FOREIGN KEY
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.GameDeveloper')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Developer')
         AND fk.[name] = N'FK_GameTrack_GameDeveloper_GameTrack_Developer'
   )
BEGIN
   ALTER TABLE GameTrack.GameDeveloper
   ADD CONSTRAINT [FK_GameTrack_GameDeveloper_GameTrack_Developer] FOREIGN KEY
   (
      DeveloperID
   )
   REFERENCES GameTrack.Game
   (
      DeveloperID
   );
END;