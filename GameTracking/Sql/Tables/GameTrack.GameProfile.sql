IF OBJECT_ID(N'GameTrack.GameProfile') IS NULL
BEGIN
	CREATE TABLE GameTrack.GameProfile
	(
		
		GameID INT NOT NULL,
        ProfileID INT NOT NULL

	
	);
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.GameProfile')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Game')
         AND fk.[name] = N'FK_GameTrack_GameProfile_GameTrack_Game'
   )
BEGIN
   ALTER TABLE GameTrack.GameProfile
   ADD CONSTRAINT [FK_GameTrack_GameProfile_GameTrack_Game] FOREIGN KEY
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.GameProfile')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Profile')
         AND fk.[name] = N'FK_GameTrack_GameProfile_GameTrack_Profile'
   )
BEGIN
   ALTER TABLE GameTrack.GameProfile
   ADD CONSTRAINT [FK_GameTrack_GameProfile_GameTrack_Profile] FOREIGN KEY
   (
      ProfileID
   )
   REFERENCES GameTrack.[Profile]
   (
      ProfileID
   );
END;