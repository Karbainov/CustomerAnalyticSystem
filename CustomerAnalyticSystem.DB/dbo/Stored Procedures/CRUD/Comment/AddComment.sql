CREATE PROCEDURE [dbo].[AddComment]
	@CustomerId integer,
	@Text nvarchar(255)
as
	insert into [dbo].[Comment] ([CustomerId],[Text])
	values 
	(@CustomerId, @Text)
