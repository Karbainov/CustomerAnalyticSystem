CREATE PROCEDURE [dbo].[AddOrder]
	@CustomerId integer, 
	@Date nvarchar(10), 
	@StatusId integer,
	
@FirstName nvarchar(50),
@LastName nvarchar(50),@Cost integer
AS
	insert dbo.[Order]
	values (@CustomerId,@FirstName,@LastName, @Date, @StatusId, @Cost)

