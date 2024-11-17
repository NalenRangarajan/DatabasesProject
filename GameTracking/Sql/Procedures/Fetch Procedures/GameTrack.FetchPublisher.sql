CREATE OR ALTER PROCEDURE GameTrack.FetchPublisher
	@PublisherID INT
AS

SELECT P.PublisherID, P.Name, P.FoundedDate, P.Location, P.Website, P.EmployeeCount
FROM GameTrack.Publisher P
WHERE P.PublisherID = @PublisherID;
GO