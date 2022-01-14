CREATE PROCEDURE [dbo].[UpdateOrderById]
	@Id integer,
	@CustomerID integer,
	@Date nvarchar(10), 
	@StatusID nvarchar,
	@Cost integer
	AS
	update dbo.[Order]
	set CustomerId = @CustomerID,
	Date = @Date,
	StatusId = @StatusId,
	Cost = @Cost
	where Id= @Id

	
RETURN @Id
