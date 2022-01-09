CREATE PROCEDURE [dbo].[AddGrade]
	@ProductId integer, @CustomerId integer, @Value nvarchar(255)
as
insert into [dbo].[Grade]
values (@ProductId, @CustomerId, @Value)
