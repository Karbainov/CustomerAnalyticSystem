CREATE PROCEDURE [dbo].[DeletePreferencesById]
	@Id integer
as
delete dbo.[Preferences]
where Id=@Id
