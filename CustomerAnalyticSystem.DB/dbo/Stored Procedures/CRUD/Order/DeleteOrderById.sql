CREATE PROCEDURE [dbo].[DeleteOrderById]
	@Id integer
AS
	delete dbo.[Order]
	where Id= @Id
RETURN 0
