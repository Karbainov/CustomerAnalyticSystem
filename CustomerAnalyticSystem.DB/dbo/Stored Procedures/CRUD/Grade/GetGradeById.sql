CREATE PROCEDURE [dbo].[GetGradeById]
	@Id integer
as
select *
from dbo.[Grade]
where id=@id
