CREATE OR ALTER PROCEDURE GameTrack.FetchCritic
	@CriticID INT
AS

SELECT C.CriticID, C.Website, C.FirstName, C.LastName
FROM GameTrack.Critic C
WHERE C.CriticID = @CriticID;
GO