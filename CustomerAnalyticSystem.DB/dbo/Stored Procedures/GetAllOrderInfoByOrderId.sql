CREATE PROCEDURE [dbo].[GetAllOrderInfoByOrderId]
@Id integer
AS
	SELECT  C.OrderId,O.StatusId,S.[Name] as "Status" ,Cust.Id as "CustomerId",C.Id, C.ProductId,Prod.[Name],Prod.[Description],G.[Name] as "GroupName", C.Amount, C.Mark FROM [dbo].[Check] AS C
	join [dbo].[Order] as O
	on C.OrderId = O.Id
	join [dbo].[Customer] as Cust
	on Cust.Id = O.CustomerId
	join [dbo].[Product] as Prod
	on C.ProductId = Prod.Id
	join [dbo].[Group] as G
	on Prod.[GroupId] = G.Id
	join [dbo].[Status] as S
	on S.Id = O.StatusId
	WHERE  C.OrderId = @Id
RETURN @Id
