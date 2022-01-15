CREATE PROCEDURE [dbo].[AddStatus]
	@Name nvarchar
AS
	insert dbo.[Status]
	values (@Name)
RETURN 0
