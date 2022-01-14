CREATE PROCEDURE [dbo].[GetCustomerById]
	@Id integer
AS
	select C.Id, C.FirstName, C.LastName, C.TypeId from [dbo].[Customer] as C
	where Id = @Id
return @Id