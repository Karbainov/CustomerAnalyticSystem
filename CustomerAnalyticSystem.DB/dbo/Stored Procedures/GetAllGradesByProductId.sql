CREATE PROCEDURE [dbo].[GetAllGradesByProductId]
	@Id integer
as
  select G.[Id] as GradeId, G.[Value]
  from [dbo].[Product] as P
  left join [dbo].[Grade] as G
  on P.Id=G.ProductId
  where P.Id=@Id
