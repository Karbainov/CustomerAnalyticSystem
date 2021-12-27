CREATE PROCEDURE [dbo].[GetGroupById]
	@Id integer
AS
	SELECT * FROM [dbo].[Group]
	WHERE Id = @Id
RETURN 0
