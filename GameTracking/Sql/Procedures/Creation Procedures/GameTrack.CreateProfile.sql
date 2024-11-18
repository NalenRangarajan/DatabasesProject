CREATE OR ALTER PROCEDURE GameTrack.CreateProfile
	@Username NVARCHAR(32) NOT NULL,
	@HashedPassword NVARCHAR(32) NOT NULL,
    @ProfileID INT OUTPUT
AS

INSERT GameTrack.[Profile](Username, HashedPassword)
VALUES (@Username, @HashedPassword);

SET @ProfileID = SCOPE_IDENTITY();
GO

