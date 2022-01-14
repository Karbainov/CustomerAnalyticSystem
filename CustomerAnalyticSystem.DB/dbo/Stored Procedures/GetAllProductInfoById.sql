CREATE PROCEDURE [dbo].[GetAllProductInfoById]
	@Id integer
AS
	SELECT P.[Id], P.[Name], P.[Description], G.[Id] as "GroupId", G.[Name] as "GroupName", O.[Id] as "OrderId"
	, C.[Id], C.[Amount], C.[Mark] from [dbo].[Product] as P
left join [dbo].[Check] as C
on P.Id=C.ProductId
left join [dbo].[Order] as O
on C.OrderId = O.ID
left join [dbo].[Group] as G
on P.GroupId=G.Id
where P.Id=@Id
RETURN @Id