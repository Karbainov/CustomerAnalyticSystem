CREATE PROCEDURE [dbo].[UpdateProduct_TagById]
  @Id integer,
  @ProductId integer,
  @TagId integer
as
  update [dbo].[Product_Tag]
  set ProductId = @ProductId,
	  TagId = @TagId
  where Id = @Id
RETURN @Id
