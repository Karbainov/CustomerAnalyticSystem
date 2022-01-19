CREATE PROCEDURE [dbo].[AddOrder]
	@CustomerID integer, 
	@Date nvarchar, 
	@StatusID nvarchar,
	@Cost integer
AS
	insert dbo.[Order]
	values (@CustomerID, @Date, @StatusID, @Cost)
RETURN 0
