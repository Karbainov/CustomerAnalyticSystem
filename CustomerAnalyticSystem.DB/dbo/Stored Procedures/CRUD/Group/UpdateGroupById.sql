CREATE PROCEDURE [dbo].[UpdateGroupById]
	@Id integer,
	@Name nvarchar (35),
	@Description nvarchar (100)
AS
	UPDATE [dbo].[Group]
	SET [dbo].[Group].[Name] = @Name,
	[dbo].[Group].[Description] = @Description
	WHERE [dbo].[Group].[Id] = @Id
RETURN 0
