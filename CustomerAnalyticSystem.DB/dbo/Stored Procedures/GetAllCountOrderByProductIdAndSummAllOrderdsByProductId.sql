CREATE PROCEDURE [dbo].[GetAllCountOrderByProductIdAndSummAllOrderdsByProductId]
	@Id integer
as
SELECT P.[Id] AS ProductId, Count(ProductId)AS CountOrder, SUM(Amount)AS SummAllProductsInOrders
FROM [dbo].[Product] as P
left join [dbo].[Check] as C
	on C.ProductId = P.Id
	where P.Id=@Id
GROUP BY ProductId, P.Id
ORDER BY ProductId
return @Id
