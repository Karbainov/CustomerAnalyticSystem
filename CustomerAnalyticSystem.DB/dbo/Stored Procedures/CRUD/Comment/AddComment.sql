CREATE PROCEDURE [dbo].[AddComment]
	@CustomerId integer,
	@Text varchar(255)
as
	insert into [dbo].[Comment]
	values 
	(@CustomerId, @Text)
