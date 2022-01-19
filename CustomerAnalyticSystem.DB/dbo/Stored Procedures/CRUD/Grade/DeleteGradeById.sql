CREATE PROCEDURE [dbo].[DeleteGradeById]
	@Id integer
as
delete dbo.[Grade]
where Id=@Id
