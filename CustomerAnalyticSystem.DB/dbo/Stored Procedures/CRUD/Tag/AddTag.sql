CREATE PROCEDURE [dbo].[AddTag]
	@Name nvarchar(50)
AS
	insert into [dbo].[Tag](Name)
	values 
  (@Name)
RETURN 0
