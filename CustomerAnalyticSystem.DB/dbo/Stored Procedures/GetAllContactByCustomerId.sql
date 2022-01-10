CREATE PROCEDURE [dbo].[GetAllContactByCustomerId]
	@Id integer
as
	select * from Contact as cont
	inner join ContactType as CT
	on cont.ContactTypeId = CT.Id
	where CustomerId = @Id
RETURN @Id
