CREATE PROCEDURE [dbo].[DeletePreferenceById]
	@Id integer
as
delete from dbo.[Preferences]
where Id=@Id
