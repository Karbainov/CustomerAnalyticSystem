CREATE PROCEDURE [dbo].[DropCustomerTypeById]
	@Id integer
as
	delete dbo.CustomerType
	where Id = @Id
RETURN @Id
