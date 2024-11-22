CREATE OR ALTER PROCEDURE GameTrack.CreateProfile
	@Username NVARCHAR(32),
	@HashedPassword NVARCHAR(32),
    @ProfileID INT OUTPUT
AS

INSERT GameTrack.[Profile](Username, HashedPassword)
VALUES (@Username, @HashedPassword);

SET @ProfileID = SCOPE_IDENTITY();
GO

