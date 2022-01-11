CREATE PROCEDURE [dbo].[GetAllOrdersByCustomerId]
	@Id integer
	as
	select * from dbo.[Order] as O
	where O.CustomerID = @Id
RETURN 0
