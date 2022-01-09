CREATE PROCEDURE [dbo].[DropCustomerTypeById]
  @Id integer
as
  delete dbo.Customer
  where Id = @Id
RETURN @Id
