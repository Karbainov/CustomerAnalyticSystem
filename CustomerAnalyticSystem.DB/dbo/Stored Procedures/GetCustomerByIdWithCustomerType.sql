CREATE PROCEDURE [dbo].[GetCustomerByIdWithCustomerType]
	@id integer
AS
	select C.Id, C.FirstName, C.LastName, C.TypeId, CT.Name from [dbo].[Customer] as C
	left join [dbo].[CustomerType] as CT
	on C.TypeId = CT.Id
	where C.Id = @id
RETURN @Id
