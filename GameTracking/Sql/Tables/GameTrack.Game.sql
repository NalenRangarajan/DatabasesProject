IF OBJECT_ID(N'GameTrack.Game') IS NULL
BEGIN
	CREATE TABLE GameTrack.Game
	(
		GameID INT NOT NULL IDENTITY(1,1),
		PublisherID INT NOT NULL,
		[Name] NVARCHAR(64) NOT NULL,
		ReleaseDate DATETIME2 NOT NULL

		CONSTRAINT [PK_GameTrack_Game_GameID] PRIMARY KEY CLUSTERED
		(
			GameID ASC
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.Game')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Publisher')
         AND fk.[name] = N'FK_GameTrack_Game_GameTrack_Publisher'
   )
BEGIN
   ALTER TABLE GameTrack.Game
   ADD CONSTRAINT [FK_GameTrack_Game_GameTrack_Publisher] FOREIGN KEY
   (
      PublisherID
   )
   REFERENCES GameTrack.Publisher
   (
      PublisherID
   );
END;

/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'GameTrack.Game')
         AND cc.[name] = N'CK_GameTrack_Game_Name'
   )
BEGIN
   ALTER TABLE GameTrack.Game
   ADD CONSTRAINT [CK_GameTrack_Game_Name] CHECK
   (
      [Name] > N''
   )
END;
