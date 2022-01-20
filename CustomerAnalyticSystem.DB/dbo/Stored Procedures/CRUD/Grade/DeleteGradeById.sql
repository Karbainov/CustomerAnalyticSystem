CREATE PROCEDURE [dbo].[DeleteGradeById]
	@Id integer
as
delete from dbo.[Grade]
where Id=@Id
return @Id
