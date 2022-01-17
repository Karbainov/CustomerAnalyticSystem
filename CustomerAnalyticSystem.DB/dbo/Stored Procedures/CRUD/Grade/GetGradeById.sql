CREATE PROCEDURE [dbo].[GetGradeById]
	@Id integer
as
select Grade.Id, Grade.ProductId, Grade.CustomerId, Grade.Value
from dbo.[Grade]
where Id=@Id
