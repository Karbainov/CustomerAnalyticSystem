CREATE PROCEDURE [dbo].[UpdateGrade]
		@Id integer, @Value nvarchar(255)
as
update dbo.[Grade]
set Value=@Value
where Id=@Id
