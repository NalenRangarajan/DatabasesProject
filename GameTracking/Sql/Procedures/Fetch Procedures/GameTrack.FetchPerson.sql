CREATE OR ALTER PROCEDURE GameTrack.FetchPerson
	@PersonID INT
AS

SELECT P.PersonID, P.FirstName, P.LastName
FROM GameTrack.Person P
WHERE P.PersonID = @PersonID;
GO