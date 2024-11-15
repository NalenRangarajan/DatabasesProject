IF OBJECT_ID(N'GameTrack.Critic') IS NULL
BEGIN
	CREATE TABLE GameTrack.Critic
	(
		CriticID INT NOT NULL IDENTITY(1,1),
		Website NVARCHAR(128) NOT NULL,
		FirstName NVARCHAR(32) NOT NULL,
		LastName NVARCHAR(32) NOT NULL

		CONSTRAINT [PK_GameTrack_Critic_CriticID] PRIMARY KEY CLUSTERED
		(
			CriticID ASC
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
      WHERE kc.parent_object_id = OBJECT_ID(N'GameTrack.Critic')
         AND kc.[name] = N'UK_GameTrack_Critic_Website'
   )
BEGIN
   ALTER TABLE GameTrack.Critic
   ADD CONSTRAINT [UK_GameTrack_Critic_Website] UNIQUE NONCLUSTERED
   (
      Website ASC
   )
END;

/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'GameTrack.Critic')
         AND cc.[name] = N'CK_GameTrack_Critic_LastName_FirstName'
   )
BEGIN
   ALTER TABLE GameTrack.Critic
   ADD CONSTRAINT [CK_GameTrack_Critic_LastName_FirstName] CHECK
   (
      FirstName > N'' AND LastName > N''
   )
END;
