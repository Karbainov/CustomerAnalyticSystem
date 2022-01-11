CREATE PROCEDURE [dbo].[UpdateTagById]
	@Id integer,
	@Name nvarchar (255)	
AS
	UPDATE [dbo].[Tag]
	SET [dbo].[Tag].[Name] = @Name	
	WHERE [dbo].[Tag].[Id] = @Id
RETURN 0
