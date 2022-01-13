CREATE PROCEDURE [dbo].[GetGroupById]
	@Id integer
AS
	SELECT G.[Id], G.[Name], G.[Description] FROM [dbo].[Group] as G
	WHERE Id = @Id
RETURN 0
