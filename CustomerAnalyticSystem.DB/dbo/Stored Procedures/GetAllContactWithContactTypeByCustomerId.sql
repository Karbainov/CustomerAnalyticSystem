CREATE PROCEDURE [dbo].[GetAllContactWithContactTypeByCustomerId]
	@Id integer
AS
	select CT.Id, CT.[Name] as ContactTypeName, C.[Value] from ContactType as CT
	inner join Contact as C
	on C.ContactTypeId = CT.Id
	where C.CustomerId = @Id
return @Id