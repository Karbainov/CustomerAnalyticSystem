CREATE PROCEDURE [dbo].[DeleteGroupById]
	@Id integer
AS
	DELETE FROM [dbo].[Group]
	WHERE Id = @Id
RETURN 0
