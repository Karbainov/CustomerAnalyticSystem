CREATE PROCEDURE [dbo].[AddStatus]
	@Name nvarchar(255)
AS
	insert dbo.[Status]
	values (@Name)

