CREATE PROCEDURE [dbo].[GetAllOrderInfoByOrderId]
@Id integer
AS
	SELECT Cust.Id as "CustomerId",C.Id, C.ProductId, C.OrderId, C.Amount, C.Mark FROM [dbo].[Check] AS C
	join [dbo].[Order] as O
	on C.OrderId = O.ID
	join [dbo].[Customer] as Cust
	on Cust.Id = O.CustomerID
	WHERE  C.OrderId = @Id
RETURN 0
