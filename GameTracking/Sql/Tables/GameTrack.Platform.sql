IF OBJECT_ID(N'GameTrack.Platform') IS NULL
BEGIN
	CREATE TABLE GameTrack.Platform
	(
		PlatformID TINYINT NOT NULL IDENTITY(1,1),
		[Name] NVARCHAR(32) NOT NULL,

		CONSTRAINT [PK_GameTrack_Platform_PlatformID] PRIMARY KEY CLUSTERED
		(
			PlatformID ASC
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
      WHERE kc.parent_object_id = OBJECT_ID(N'GameTrack.Platform')
         AND kc.[name] = N'UK_GameTrack_Platform_Name'
   )
BEGIN
   ALTER TABLE GameTrack.[Platform]
   ADD CONSTRAINT [UK_GameTrack_Platform_Name] UNIQUE NONCLUSTERED
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
      WHERE cc.parent_object_id = OBJECT_ID(N'GameTrack.Platform')
         AND cc.[name] = N'CK_GameTrack_Platform_Name'
   )
BEGIN
   ALTER TABLE GameTrack.[Platform]
   ADD CONSTRAINT [CK_GameTrack_Platform_Name] CHECK
   (
      Name > N''
   )
END;