﻿IF OBJECT_ID(N'GameTrack.GameProfile') IS NULL
BEGIN
	CREATE TABLE GameTrack.GameProfile
	(
		
		GameID INT NOT NULL IDENTITY(1,1),
        ProfileID INT NOT NULL IDENTITY(1,1)

		CONSTRAINT [PK_GameTrack_ProfileGame_GameID_ProfileID] PRIMARY KEY CLUSTERED
		(
            GameID ASC,
			ProfileID ASC
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.ProfileGame')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Game')
         AND fk.[name] = N'FK_GameTrack_ProfileGame_GameTrack_Game'
   )
BEGIN
   ALTER TABLE GameTrack.ProfileGame
   ADD CONSTRAINT [FK_GameTrack_ProfileGame_GameTrack_Game] FOREIGN KEY
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.ProfileGame')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Profile')
         AND fk.[name] = N'FK_GameTrack_ProfileGame_GameTrack_Profile'
   )
BEGIN
   ALTER TABLE GameTrack.ProfileGame
   ADD CONSTRAINT [FK_GameTrack_ProfileGame_GameTrack_Profile] FOREIGN KEY
   (
      ProfileID
   )
   REFERENCES GameTrack.[Profile]
   (
      ProfileID
   );
END;