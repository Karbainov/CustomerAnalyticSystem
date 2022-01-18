CREATE PROCEDURE [dbo].[GetAllCommentByCustomerId]
  @Id integer
as
  select C.Id,C.CustomerId, C.[Text] from [dbo].[Comment] as C
  where CustomerId = @Id
RETURN @Id