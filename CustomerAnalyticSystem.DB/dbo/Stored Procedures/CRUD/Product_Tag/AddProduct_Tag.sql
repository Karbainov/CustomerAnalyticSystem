﻿CREATE PROCEDURE [dbo].[AddProduct_Tag]
  @ProductId integer,
  @TagId integer
as
  insert into [dbo].[Product_Tag] (ProductId, TagId)
  values 
(@ProductId, @TagId)