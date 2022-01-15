CREATE PROCEDURE [dbo].[DeletePreferenceById]
	@Id integer
as
delete dbo.[Preferences]
where Id=@Id
