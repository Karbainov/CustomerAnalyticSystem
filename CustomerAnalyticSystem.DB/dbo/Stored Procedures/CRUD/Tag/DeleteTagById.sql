CREATE PROCEDURE [dbo].[DeleteTagById]
	@Id integer
AS
	delete from Tag 
	where Id = @Id
return @Id