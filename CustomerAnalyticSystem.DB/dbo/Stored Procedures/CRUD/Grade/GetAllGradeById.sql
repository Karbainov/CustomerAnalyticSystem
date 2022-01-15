CREATE PROCEDURE [dbo].[GetAllGradeById]
	@Id integer
as
select *
from dbo.[Grade]
where Id=@Id
