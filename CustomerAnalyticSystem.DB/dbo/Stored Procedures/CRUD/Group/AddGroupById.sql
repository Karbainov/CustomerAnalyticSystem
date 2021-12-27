CREATE PROCEDURE [dbo].[AddGroupById]
	@Name nvarchar(35),
	@Description nvarchar(100)
AS
	INSERT INTO [dbo].[Group]
	VALUES(@Name, @Description)
RETURN 0
