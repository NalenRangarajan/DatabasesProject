IF OBJECT_ID(N'GameTrack.Person') IS NULL
BEGIN
	CREATE TABLE GameTrack.Person
	(
		PersonID INT NOT NULL IDENTITY(1,1),
		FirstName NVARCHAR(32) NOT NULL,
        LastName NVARCHAR(32) NOT NULL

		CONSTRAINT [PK_GameTrack_Person_PersonID] PRIMARY KEY CLUSTERED
		(
			PersonID ASC
		)
	);
END;


/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'GameTrack.Person')
         AND cc.[name] = N'CK_GameTrack_Person_FirstName_LastName'
   )
BEGIN
   ALTER TABLE GameTrack.Person
   ADD CONSTRAINT [CK_GameTrack_Person_FirstName_LastName] CHECK
   (
      FirstName > N'' AND LastName > N''
   )
END;

