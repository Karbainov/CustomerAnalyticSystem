CREATE PROCEDURE [dbo].[DeleteGrade]
	@Id integer
as
delete dbo.[Grade]
where Id=@Id
