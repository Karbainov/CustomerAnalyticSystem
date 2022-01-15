CREATE PROCEDURE [dbo].[GetPreferenceById]
	@Id integer
as
select *
from dbo.[Preferences]
where Id=@Id