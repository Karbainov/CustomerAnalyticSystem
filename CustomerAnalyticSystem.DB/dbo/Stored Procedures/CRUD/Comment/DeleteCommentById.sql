CREATE PROCEDURE [dbo].[DeleteCommentById]
	@Id integer
as
	delete [dbo].[Comment]
	where Id=@Id
