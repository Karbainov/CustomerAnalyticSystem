CREATE PROCEDURE [dbo].[GetAllGradesByProductId]
	@Id integer
as
  select G.Id, G.CustomerId, G.CustomerId, G.[Value] from Grade as G
  where ProductId = @Id
