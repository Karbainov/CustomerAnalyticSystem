CREATE PROCEDURE [dbo].[AddContactType]
	@Name nvarchar(50)
	as
	insert dbo.[ContactType]
	values (@Name)
RETURN 0
