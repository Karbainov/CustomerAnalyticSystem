CREATE PROCEDURE [dbo].[AddProduct_Tag]
  @ProductId integer,
  @TagId integer
as
  insert into [dbo].[Product_tag] (ProductId, TagId)
  values 
(@ProductId, @TagId)