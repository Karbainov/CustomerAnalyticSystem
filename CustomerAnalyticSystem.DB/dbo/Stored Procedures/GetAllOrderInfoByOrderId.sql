CREATE PROCEDURE [dbo].[GetAllOrderInfoByOrderId]
@Id integer
AS
	SELECT C.Id, C.ProductId, C.OrderId, C.Amount, C.Mark FROM [dbo].[Check] AS C
	WHERE  C.OrderId = @Id
RETURN 0
