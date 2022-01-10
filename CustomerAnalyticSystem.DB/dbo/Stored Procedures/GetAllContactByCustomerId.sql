CREATE PROCEDURE [dbo].[GetAllContactByCustomerId]
	@Id integer
as
	select C.CustomerId, C.Value, CT.Name from Contact as C
	inner join ContactType as CT
	on C.ContactTypeId = CT.Id
	where CustomerId = @Id

RETURN @Id
