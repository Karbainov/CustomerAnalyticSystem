CREATE PROCEDURE [dbo].[GetStatusById]
	@Id integer 
AS
	select *
	from dbo.[Status]
	where Id = @Id
RETURN 0
