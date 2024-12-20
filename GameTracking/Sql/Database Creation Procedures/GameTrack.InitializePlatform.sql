﻿
DECLARE @PlatformStaging TABLE
(
	PlatformID INT NOT NULL IDENTITY(1,1),
		[Name] NVARCHAR(32) NOT NULL
);

/***************************** Modify values here *****************************/

INSERT @PlatformStaging([Name])
VALUES
	(N'Wii'),
(N'NES'),
(N'GB'),
(N'DS'),
(N'X360'),
(N'PS3'),
(N'PS2'),
(N'SNES'),
(N'GBA'),
(N'3DS'),
(N'PS4'),
(N'N64'),
(N'PS'),
(N'XB'),
(N'PC'),
(N'2600'),
(N'PSP'),
(N'XOne'),
(N'GC'),
(N'WiiU'),
(N'GEN'),
(N'DC'),
(N'PSV'),
(N'SAT'),
(N'SCD'),
(N'WS'),
(N'NG'),
(N'TG16'),
(N'3DO'),
(N'GG'),
(N'PCFX');

/******************************************************************************/

MERGE GameTrack.[Platform] T
USING @PlatformStaging S ON S.PlatformID = T.PlatformID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name])
   VALUES(S.[Name]);
