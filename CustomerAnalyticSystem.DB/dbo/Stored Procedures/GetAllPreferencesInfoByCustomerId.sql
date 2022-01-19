CREATE PROCEDURE [dbo].[GetAllPreferencesInfoByCustomerId]
	@Id integer
AS
	select Pref.ProductId, P.[Name], P.[Description],Pref.TagId,T.[Name],Pref.GroupId,G.[Name],G.[Description], Pref.IsInterested from[dbo].[Preferences] as Pref
full join  [dbo].[Product] as P
on Pref.ProductId = P.Id
full join [dbo].[Tag] as T
on Pref.TagId = T.Id
full join [dbo].[Group] as G
on Pref.GroupId = G.Id
where Pref.CustomerId = @Id
RETURN 0
