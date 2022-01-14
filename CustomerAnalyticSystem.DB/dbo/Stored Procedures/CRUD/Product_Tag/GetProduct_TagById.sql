CREATE PROCEDURE [dbo].[GetProduct_TagById]
	@Id integer
AS
	SELECT PT.Id, PT.ProductId, PT.TagId FROM [dbo].[Product_Tag] as PT
	WHERE Id = @Id
RETURN @Id