IF OBJECT_ID(N'GameTrack.Genre') IS NULL
BEGIN
   CREATE TABLE GameTrack.Genre
   ( 
      GenreID INT NOT NULL IDENTITY(1,1),
      [Name] VARCHAR(32) NOT NULL,

      CONSTRAINT PK_GameTrack_Genre_GenreID PRIMARY KEY CLUSTERED
      (
         GenreID ASC
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
      WHERE kc.parent_object_id = OBJECT_ID(N'GameTrack.Genre')
         AND kc.[name] = N'UK_GameTrack_Genre_Name'
   )
BEGIN
   ALTER TABLE GameTrack.Genre
   ADD CONSTRAINT [UK_GameTrack_Genre_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;