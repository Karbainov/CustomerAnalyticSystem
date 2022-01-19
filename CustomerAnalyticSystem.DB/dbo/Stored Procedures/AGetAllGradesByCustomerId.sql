CREATE PROCEDURE [dbo].[AGetAllGradesByCustomerId]
@Id integer
AS
select G.ProductId, G.CustomerId, G.[Value], C.FirstName, C.LastName, P.[Name], P.[Description] from [dbo].[Grade] as G
join [dbo].[Customer] as C
on G.CustomerId = C.Id
join [dbo].Product as P
on G.ProductId = p.Id
where C.Id = @Id
RETURN @Id
