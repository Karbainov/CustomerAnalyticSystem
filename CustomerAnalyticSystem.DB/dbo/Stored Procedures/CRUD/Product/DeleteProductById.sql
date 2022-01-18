CREATE PROCEDURE [dbo].[DeleteProductById]
	@Id integer
AS
	DELETE FROM [dbo].[Product]
	WHERE Id = @Id
RETURN @Id
