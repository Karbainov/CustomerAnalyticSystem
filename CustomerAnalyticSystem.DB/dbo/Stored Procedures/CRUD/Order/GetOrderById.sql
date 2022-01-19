CREATE PROCEDURE [dbo].[GetOrderById]
	@Id integer
AS
	select O.Id, O.CustomerID, O.Date, O.StatusID, O.Cost from dbo.[Order] as O
	where Id = @Id
RETURN @Id
