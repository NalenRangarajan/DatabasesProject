IF OBJECT_ID(N'GameTrack.Developer') IS NULL
BEGIN
	CREATE TABLE GameTrack.Developer
	(
		DeveloperID INT NOT NULL IDENTITY(1,1),
		[Name] NVARCHAR(32) NOT NULL,
		Website NVARCHAR(128) NOT NULL,
		FoundedDate DATETIME2 NOT NULL,
		[Location] NVARCHAR(128) NOT NULL,
		TeamCount INT NOT NULL

		CONSTRAINT [PK_GameTrack_Developer_DeveloperID] PRIMARY KEY CLUSTERED
		(
			DeveloperID ASC
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
      WHERE kc.parent_object_id = OBJECT_ID(N'GameTrack.Developer')
         AND kc.[name] = N'UK_GameTrack_Developer_Name_Website'
   )
BEGIN
   ALTER TABLE GameTrack.Developer
   ADD CONSTRAINT [UK_GameTrack_Developer_Website] UNIQUE NONCLUSTERED
   (
      Website ASC
   )
   ALTER TABLE GameTrack.Developer
   ADD CONSTRAINT [UK_GameTrack_Developer_Name] UNIQUE NONCLUSTERED
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
      WHERE cc.parent_object_id = OBJECT_ID(N'GameTrack.Developer')
         AND cc.[name] = N'CK_GameTrack_Developer_Name_Website'
   )
BEGIN
   ALTER TABLE GameTrack.Developer
   ADD CONSTRAINT [CK_GameTrack_Developer_Name_Website] CHECK
   (
      [Name] > N'' AND Website > N''
   )
END;
