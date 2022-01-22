CREATE PROCEDURE [dbo].[DropCustomerById]
	@Id integer
AS
update [dbo].[Customer] 
set IsDeleted = 1
	where Id = @Id
	return @Id