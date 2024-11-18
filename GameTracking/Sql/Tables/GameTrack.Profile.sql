IF OBJECT_ID(N'GameTrack.Profile') IS NULL
BEGIN
	CREATE TABLE GameTrack.[Profile]
	(
		ProfileID INT NOT NULL IDENTITY(1,1),
		Username NVARCHAR(32) NOT NULL,
		HashedPassword NVARCHAR(32) NOT NULL,
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())

		CONSTRAINT [PK_GameTrack_Profile_ProfileID] PRIMARY KEY CLUSTERED
		(
			ProfileID ASC
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
      WHERE kc.parent_object_id = OBJECT_ID(N'GameTrack.Profile')
         AND kc.[name] = N'UK_GameTrack_Profile_Username'
   )
BEGIN
   ALTER TABLE GameTrack.[Profile]
   ADD CONSTRAINT [UK_GameTrack_Profile_Username] UNIQUE NONCLUSTERED
   (
      Username ASC
   )
END;

/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'GameTrack.Profile')
         AND cc.[name] = N'CK_GameTrack_Profile_Username'
   )
BEGIN
   ALTER TABLE GameTrack.Profile
   ADD CONSTRAINT [CK_GameTrack_Profile_Username] CHECK
   (
      Username > N''
   )
END;
