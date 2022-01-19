CREATE PROCEDURE [dbo].[GetAllProductsByTag]
	@Id integer
	as
	select P.[GroupId], P.[Name], P.[Description] from dbo.[Product] as P
	inner join Product_Tag as PT
	on PT.ProductId = P.Id and PT.TagId = @Id
RETURN 0
