CREATE PROCEDURE GameTrack.InitializePlatform
AS
DECLARE @PlatformStaging TABLE
(
   PlatformID TINYINT NOT NULL PRIMARY KEY,
   [Name] VARCHAR(8) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @PlatformStaging(PlatformID, [Name])
VALUES
	(1,N'Wii'),
	(2,N'NES'),
	(3,N'GB'),
	(4,N'DS'),
	(5,N'X360'),
	(6,N'PS3'),
	(7,N'PS2'),
	(8,N'SNES'),
	(9,N'GBA'),
	(10,N'3DS'),
	(11,N'PS4'),
	(12,N'N64'),
	(13,N'PS'),
	(14,N'XB'),
	(15,N'PC'),
	(16,N'2600'),
	(17,N'PSP'),
	(18,N'XOne'),
	(19,N'GC'),
	(20,N'WiiU'),
	(21,N'GEN'),
	(22,N'DC'),
	(23,N'PSV'),
	(24,N'SAT'),
	(25,N'SCD'),
	(26,N'WS'),
	(27,N'NG'),
	(28,N'TG16'),
	(29,N'3DO'),
	(30,N'GG'),
	(31,N'PCFX');

/******************************************************************************/

MERGE GameTrack.[Platform] T
USING @PlatformStaging S ON S.PlatformID = T.PlatformID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(PlatformID, [Name])
   VALUES(S.PlatformID, S.[Name]);
