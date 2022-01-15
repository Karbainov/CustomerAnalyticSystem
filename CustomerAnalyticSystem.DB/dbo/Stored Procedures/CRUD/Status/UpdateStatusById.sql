CREATE PROCEDURE [dbo].[UpdateStatusById]
	@Id integer, 
	@Name nvarchar(255)
AS
	update dbo.[Status]
	set Name = @Name
	where Id= @Id
RETURN 0
