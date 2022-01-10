CREATE PROCEDURE [dbo].[GetAllCommentByCustomerId]
  @Id integer
as
  select * from Comment
  where CustomerId = @Id
RETURN @Id