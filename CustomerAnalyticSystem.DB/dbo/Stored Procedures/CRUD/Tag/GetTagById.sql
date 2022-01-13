CREATE PROCEDURE [dbo].[GetTagById]
	@Id integer
AS
	SELECT * FROM [dbo].[Tag]
	WHERE Id = @Id
RETURN 0
