﻿IF OBJECT_ID(N'GameTrack.Review') IS NULL
BEGIN
	CREATE TABLE GameTrack.Review
	(
		ReviewID INT NOT NULL IDENTITY(1,1),
		GameID INT NOT NULL,
		CriticID INT NOT NULL,
		Score INT NOT NULL,
		Title NVARCHAR(32),
		Body NVARCHAR(512),
		ReviewDate DATETIME2 NOT NULL DEFAULT(SYSDATETIME())

		CONSTRAINT [PK_GameTrack_Review_ReviewID] PRIMARY KEY CLUSTERED
		(
			ReviewID ASC
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.Review')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Game')
         AND fk.[name] = N'FK_GameTrack_Review_GameTrack_Game'
   )
BEGIN
   ALTER TABLE GameTrack.Review
   ADD CONSTRAINT [FK_GameTrack_Review_GameTrack_Game] FOREIGN KEY
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
      WHERE fk.parent_object_id = OBJECT_ID(N'GameTrack.Review')
         AND fk.referenced_object_id = OBJECT_ID(N'GameTrack.Critic')
         AND fk.[name] = N'FK_GameTrack_Review_GameTrack_Critic'
   )
BEGIN
   ALTER TABLE GameTrack.Review
   ADD CONSTRAINT [FK_GameTrack_Review_GameTrack_Critic] FOREIGN KEY
   (
     CriticID
   )
   REFERENCES GameTrack.Critic
   (
      CriticID
   );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'GameTrack.Review')
         AND kc.[name] = N'UK_GameTrack_Review_GameID_CriticID'
   )
BEGIN
   ALTER TABLE GameTrack.Developer
   ADD CONSTRAINT [UK_GameTrack_Review_GameID_CriticID] UNIQUE NONCLUSTERED
   (
      GameID ASC,
      CriticID ASC
   )
END;

