CREATE PROCEDURE [dbo].[GetAllGroup]
AS
	SELECT G.Id, G.Name, G.Description from [dbo].[Group] as G
RETURN 0
