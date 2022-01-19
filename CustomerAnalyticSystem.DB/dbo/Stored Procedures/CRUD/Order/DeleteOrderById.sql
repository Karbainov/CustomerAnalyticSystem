CREATE PROCEDURE [dbo].[DeleteOrderById]
	@Id integer
AS
	delete from dbo.[Order]
	where Id= @Id
RETURN @Id
