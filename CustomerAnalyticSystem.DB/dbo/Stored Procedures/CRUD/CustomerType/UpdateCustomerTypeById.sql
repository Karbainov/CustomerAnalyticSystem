CREATE PROCEDURE [dbo].[UpdateCustomerTypeById]
  @Id integer,
  @Name nvarchar
as
  update dbo.CustomerType
  set [Name] = @Name
  where Id = @Id