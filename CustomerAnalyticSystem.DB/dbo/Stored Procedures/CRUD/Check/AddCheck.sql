CREATE PROCEDURE [dbo].[AddCheck]
	@ProductId integer,
	@OrderId integer,
	@Amount integer,
	@Mark integer
as 
	insert into [dbo].[Check] ([ProductId],[OrderId],[Amount],[Mark])
	values
	(@ProductId, @OrderId, @Amount, @Mark)