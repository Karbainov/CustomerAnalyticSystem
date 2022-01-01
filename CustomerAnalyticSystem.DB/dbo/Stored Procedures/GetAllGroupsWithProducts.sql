CREATE PROCEDURE [dbo].[GetAllGroupsWithProducts]
AS
	SELECT * from [dbo].[Group] as G
	join [dbo].[Product] as P
	on P.GroupId = G.Id
	 ORDER BY G.Name
RETURN 0
