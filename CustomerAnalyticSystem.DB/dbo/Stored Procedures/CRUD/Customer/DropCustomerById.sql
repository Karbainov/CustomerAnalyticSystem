CREATE PROCEDURE [dbo].[DropCustomerById]
	@Id integer
AS
	delete from [dbo].[Customer] 
	where Id = @Id
	return @Id