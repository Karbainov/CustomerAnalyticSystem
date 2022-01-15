CREATE PROCEDURE [dbo].[UpdatePreferenceById]
	@Id integer, @IsInterested bit
as
update dbo.[Preferences]
set IsInterested=@IsInterested
where Id=@Id
