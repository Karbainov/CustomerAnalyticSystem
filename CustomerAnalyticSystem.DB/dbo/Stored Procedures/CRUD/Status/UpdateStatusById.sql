CREATE PROCEDURE [dbo].[UpdateStatusById]
	@Id integer, 
	@Name nvarchar
AS
	update dbo.[Status]
	set Name = @Name
	where Id= @Id
RETURN 0
