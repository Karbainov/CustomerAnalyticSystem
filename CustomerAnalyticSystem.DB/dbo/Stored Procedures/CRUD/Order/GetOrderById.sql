CREATE PROCEDURE [dbo].[GetOrderById]
	@Id integer
AS
	select *
	from dbo.[Order]
	where Id = @Id
RETURN 0
