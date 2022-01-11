CREATE PROCEDURE [dbo].[DropCustomerById]
	@Id integer
AS
	delete from Customer 
	where Id = @Id
	return @Id