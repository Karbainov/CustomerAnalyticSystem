CREATE PROCEDURE [dbo].[GetAllTags]
	as
select Tag.Id, Tag.[Name]
from [dbo].[Tag]
