CREATE PROCEDURE [dbo].[UpdateGradeById]
		@Id integer, @Value nvarchar(50)
as
update dbo.[Grade]
set Value=@Value
where Id=@Id
