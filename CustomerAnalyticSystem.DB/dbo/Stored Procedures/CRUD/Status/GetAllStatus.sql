CREATE PROCEDURE [dbo].[GetAllStatus]
	as
	select S.[Id], S.[Name] from [dbo].[Status] as S
	
RETURN 0
