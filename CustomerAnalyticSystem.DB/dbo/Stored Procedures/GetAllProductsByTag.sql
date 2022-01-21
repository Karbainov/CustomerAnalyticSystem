CREATE PROCEDURE [dbo].[GetAllProductsByTag]
	@Id integer
	as
	select P.[Id], G.[Name] as GroupName, P.[Name], P.[Description] from dbo.[Product] as P
	inner join Product_Tag as PT
	on PT.ProductId = P.Id and PT.TagId = @Id
	inner join dbo.[Group] as G
	on G.Id = P.GroupId
RETURN 0
