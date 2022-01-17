CREATE PROCEDURE [dbo].[DeleteStatusById]
	@Id integer
AS
	delete from dbo.[Status]
	where Id= @Id

