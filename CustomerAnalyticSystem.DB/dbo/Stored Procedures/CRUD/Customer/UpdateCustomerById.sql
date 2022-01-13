CREATE PROCEDURE [dbo].[UpdateCustomerById]
  @Id integer,
  @FirstName nvarchar,
  @LastName nvarchar,
  @TypeId integer
as
  update [dbo].[Customer]
  set FirstName = @FirstName,
  LastName = @LastName,
  TypeId = @TypeId
  where Id = @Id
RETURN @Id
