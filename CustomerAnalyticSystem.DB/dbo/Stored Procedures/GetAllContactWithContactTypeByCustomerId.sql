CREATE PROCEDURE [dbo].[GetAllContactWithContactTypeByCustomerId]
	@Id integer
AS
	select CT.Id, CT.[Name], C.[Value] from ContactType as CT
	inner join Contact as C
	on C.ContactTypeId = CT.Id
	where C.CustomerId = @Id
return @Id
