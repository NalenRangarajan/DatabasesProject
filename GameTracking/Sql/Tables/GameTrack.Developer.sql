IF OBJECT_ID(N'GameTrack.Developer') IS NULL
BEGIN
	CREATE TABLE GameTrack.Developer
	(
		DeveloperID INT NOT NULL IDENTITY(1,1),
		[Name] NVARCHAR(32) NOT NULL,
		Email NVARCHAR(128),
		FoundedDate DATETIME2,
		[Location] NVARCHAR(128),
		TeamCount INT

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
         AND kc.[name] = N'UK_GameTrack_Developer_Name_Email'
   )
BEGIN
   ALTER TABLE GameTrack.Developer
   ADD CONSTRAINT [UK_GameTrack_Developer_Email] UNIQUE NONCLUSTERED
   (
      Email ASC
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
         AND cc.[name] = N'CK_GameTrack_Developer_Name_Email'
   )
BEGIN
   ALTER TABLE GameTrack.Developer
   ADD CONSTRAINT [CK_GameTrack_Developer_Name_Email] CHECK
   (
      [Name] > N'' AND Email > N''
   )
END;
