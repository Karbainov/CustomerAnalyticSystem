CREATE PROCEDURE [dbo].[UpdateOrderById]
	@Id integer,
	@CustomerId integer,@FirstName nvarchar(50),
@LastName nvarchar(50),
	@Date nvarchar(10), 
	@StatusId integer,

	@Cost integer
	AS
	update dbo.[Order]
	set CustomerId = @CustomerId,
FirstName = @FirstName,
LastName = @LastName,
	Date = @Date,
	StatusId = @StatusId,
	Cost = @Cost
	where Id= @Id

	
RETURN @Id
