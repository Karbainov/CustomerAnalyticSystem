CREATE PROCEDURE [dbo].[GetAllPreferencesById]
	@Id integer
as
select *
from dbo.[Preferences]
where Id=@Id
