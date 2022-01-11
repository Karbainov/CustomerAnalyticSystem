CREATE PROCEDURE [dbo].[DeleteStatusById]
	@Id integer
AS
	delete dbo.[Status]
	where Id= @Id
RETURN 0
