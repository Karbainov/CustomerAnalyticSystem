CREATE PROCEDURE [dbo].[GetAllOrdersByCustomerId]
	@Id integer
	as
	select * from dbo.[Order] as O
	inner join dbo.[Check] as C
	on C.OrderId = O.Id
	inner join dbo.[Product] as P
	on C.ProductId = P.Id
	where O.CustomerId = @Id
RETURN 0
