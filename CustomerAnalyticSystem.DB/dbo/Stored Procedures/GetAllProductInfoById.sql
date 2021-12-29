CREATE PROCEDURE [dbo].[GetAllProductInfoById]
	@Id integer
AS
	SELECT P.Name, C.Mark, C.Amount, O.Date, O.CustomerID, G.Name from [dbo].[Product] as P
left join [dbo].[Check] as C
on P.Id=C.ProductId
left join [dbo].[Order] as O
on C.OrderId = O.ID
left join [dbo].[Group] as G
on P.GroupId=G.Id
where P.Id=@Id
RETURN 0
