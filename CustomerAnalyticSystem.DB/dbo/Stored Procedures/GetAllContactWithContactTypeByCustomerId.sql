CREATE PROCEDURE [dbo].[GetAllContactWithContactTypeByCustomerId]
	@Id integer
AS
	select C.Id, CT.[Name] as ContactTypeName, C.[Value] from ContactType as CT
	left join Contact as C
	on C.ContactTypeId = CT.Id
	where C.CustomerId = @Id
return @Id