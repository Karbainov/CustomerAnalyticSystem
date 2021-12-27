CREATE PROCEDURE [dbo].[AddProduct]
	@Name nvarchar(30),
	@Description nvarchar(30),
	@GroupId integer
AS
	insert into [dbo].[Product]
  values 
  (@Name, @Description, @GroupId)
RETURN 0
