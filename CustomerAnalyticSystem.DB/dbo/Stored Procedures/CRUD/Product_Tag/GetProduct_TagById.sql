CREATE PROCEDURE [dbo].[GetProduct_TagById]
	@Id integer
AS
	SELECT * FROM [dbo].[Product_Tag]
	WHERE Id = @Id
RETURN 0