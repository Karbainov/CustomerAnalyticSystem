CREATE PROCEDURE [dbo].[GetAllGradesByCustomerId]
	@Id integer
as
  select C.Name, C.Age, P.Name, P.Description, G.Value, Ch.Amount, Ch.Mark from Grade as G
  left join [dbo].[Customer] as C
  on C.Id=G.CustomerId
  left join [dbo].[Product] as P
  on P.Id=G.ProductId
  left join [dbo].[Check] as Ch
  on P.Id=Ch.ProductId
  where C.Id= @Id
RETURN @Id
