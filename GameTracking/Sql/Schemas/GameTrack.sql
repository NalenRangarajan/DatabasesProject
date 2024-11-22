If NOT EXISTS
	(
		SELECT *
		FROM sys.schemas s
		WHERE s.[name] = N'GameTrack'
	)
BEGIN EXEC(N'CREATE SCHEMA [GameTrack] AUTHORIZATION [dbo]');
END;