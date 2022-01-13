CREATE PROCEDURE [dbo].[AddCustomerType]
  @Name nvarchar
as
  insert into [dbo].[CustomerType] ([Name])
  values 
  (@Name)
