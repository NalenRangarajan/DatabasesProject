﻿IF OBJECT_ID(N'GameTrack.GamePlatform') IS NULL
BEGIN
	CREATE TABLE GameTrack.GamePlatform
	(
		GameID INT NOT NULL,
		PlatformID INT NOT NULL

		
	);
END;


/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.GamePlatform')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Game')
         AND fk.[name] = N'FK_GameTrack_GamePlatform_GameTrack_Game'
   )
BEGIN
   ALTER TABLE GameTrack.GamePlatform
   ADD CONSTRAINT [FK_GameTrack_GamePlatform_GameTrack_Game] FOREIGN KEY
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.GamePlatform')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Platform')
         AND fk.[name] = N'FK_GameTrack_GamePlatform_GameTrack_Platform'
   )
BEGIN
   ALTER TABLE GameTrack.GamePlatform
   ADD CONSTRAINT [FK_GameTrack_GamePlatform_GameTrack_Platform] FOREIGN KEY
   (
      PlatformID
   )
   REFERENCES GameTrack.[Platform]
   (
      PlatformID
   );
END;