CREATE PROCEDURE [dbo].[GetCustomerTypeById]
  @Id integer
as
  select CT.Id, CT.Name from dbo.[CustomerType] as CT
  where Id = @Id
RETURN @Id
