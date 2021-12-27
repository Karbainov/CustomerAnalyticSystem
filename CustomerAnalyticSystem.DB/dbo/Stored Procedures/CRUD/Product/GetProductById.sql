CREATE PROCEDURE [dbo].[GetProductById]
	@Id integer
AS
	SELECT * from [dbo].[Product]
	where Id = @Id
RETURN 0
