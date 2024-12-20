﻿IF OBJECT_ID(N'GameTrack.Publisher') IS NULL
BEGIN
	CREATE TABLE GameTrack.Publisher
	(
		PublisherID INT NOT NULL IDENTITY(1,1),
		[Name] NVARCHAR(64) NOT NULL,
		FoundedDate DATETIME2,
		[Location] NVARCHAR(256),
		Email NVARCHAR(128),
		EmployeeCount INT 

		CONSTRAINT [PK_GameTrack_Publisher_PublisherID] PRIMARY KEY CLUSTERED
		(
			PublisherID ASC
		)
	);
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'GameTrack.Publisher')
         AND kc.[name] = N'UK_GameTrack_Publisher_Name'
   )
BEGIN
   ALTER TABLE GameTrack.Publisher
   ADD CONSTRAINT [UK_GameTrack_Publisher_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;



/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'GameTrack.Publisher')
         AND cc.[name] = N'CK_GameTrack_Publisher_Name'
   )
BEGIN
   ALTER TABLE GameTrack.Publisher
   ADD CONSTRAINT [CK_GameTrack_Publisher_Name] CHECK
   (
      [Name] > N''
   )
END;

