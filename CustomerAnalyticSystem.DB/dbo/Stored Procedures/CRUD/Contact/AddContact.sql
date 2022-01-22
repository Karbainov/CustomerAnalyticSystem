CREATE PROCEDURE [dbo].[AddContact]
	@CustomerId integer,
	@ContactTypeId integer,
	@Value nvarchar(255),
	@IsDeleted bit = 0
as
	insert dbo.[Contact] 
	values (@CustomerId , @ContactTypeId , @Value, @IsDeleted)
RETURN 0
RETURN 0
