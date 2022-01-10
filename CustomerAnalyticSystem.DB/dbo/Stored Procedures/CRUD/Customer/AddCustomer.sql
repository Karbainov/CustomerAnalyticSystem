CREATE PROCEDURE [dbo].[AddCustomer]
  @LastName nvarchar(50),
  @FirstName nvarchar(50),
  @TypeId integer
as
  insert into dbo.Customer (LastName, FirstName, TypeId)
  values 
  (@LastName, @FirstName, @TypeId)