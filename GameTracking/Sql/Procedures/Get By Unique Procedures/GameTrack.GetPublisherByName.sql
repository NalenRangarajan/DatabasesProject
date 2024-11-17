CREATE OR ALTER PROCEDURE GameTrack.GetPublisherByName
	@Name NVARCHAR(32)
AS

SELECT P.PublisherID, P.Name, P.FoundedDate, P.Location, P.Website, P.EmployeeCount
FROM GameTrack.Publisher P
WHERE P.Name = @Name;
GO