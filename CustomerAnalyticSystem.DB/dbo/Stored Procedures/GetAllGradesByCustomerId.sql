CREATE PROCEDURE [dbo].[GetAllGradesByCustomerId]
	@Id integer
as
  select C.[FirstName], C.[LastName], P.[Name], G.[Value] as ProductGrade, Ch.[Amount]as AmountProduct, Ch.[Mark] as OrderGrade from [dbo].[Customer] as C
  left join [dbo].[Grade] as G
  on C.Id=G.CustomerId
  left join [dbo].[Product] as P
  on P.Id=G.ProductId
  left join [dbo].[Check] as Ch
  on P.Id=Ch.ProductId
  where C.Id= @Id
RETURN @Id
