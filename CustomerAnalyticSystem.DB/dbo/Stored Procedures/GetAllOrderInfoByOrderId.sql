CREATE PROCEDURE [dbo].[GetAllOrderInfoByOrderId]
@Id integer
AS
	SELECT C.Id, C.ProductId AS "Product Id", C.OrderId AS "Order Id", C.Amount, C.Mark FROM [dbo].[Check] AS C
	WHERE  C.OrderId = @Id
RETURN 0
