CREATE PROCEDURE [dbo].[GetAllProductInfoById]
	@Id integer
AS
	SELECT P.Name, C.Mark, C.Amount, O.Date, O.CustomerID from [dbo].[Product] as P
join [dbo].[Check] as C
on P.Id=C.ProductId
join [dbo].[Order] as O
on C.OrderId = O.ID
where P.Id=@Id
RETURN 0
