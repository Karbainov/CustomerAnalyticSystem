CREATE PROCEDURE [dbo].[GetTagById]
	@Id integer
AS
	SELECT Tag.Id, Tag.[Name] FROM [dbo].[Tag]
	WHERE Id = @Id
RETURN @Id
