CREATE PROCEDURE [dbo].[GetAllProductsByGroupId]
@Id integer
as
select P.Id, P.Name, P.Description, P.GroupId from [dbo].[Product] as P
where P.GroupId = @Id
RETURN @Id
