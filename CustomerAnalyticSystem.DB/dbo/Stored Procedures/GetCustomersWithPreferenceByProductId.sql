CREATE PROCEDURE [dbo].[GetCustomersWithPreferenceByProductId]
@Id integer
as
select C.Id, C.FirstName, C.LastName, C.TypeId, P.ProductId, P.TagId, 
P.GroupId, P.IsInterested from  [dbo].[Customer] as C
left join [dbo].[Preferences] as P
on C.Id = p.CustomerId
where P.ProductId = @Id
RETURN 0
