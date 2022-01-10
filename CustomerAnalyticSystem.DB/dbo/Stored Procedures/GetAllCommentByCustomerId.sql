CREATE PROCEDURE [dbo].[GetAllCommentByCustomerId]
  @Id integer
as
  select Comment.Id,Comment.CustomerId, Comment.Text from Comment
  where CustomerId = @Id
RETURN @Id