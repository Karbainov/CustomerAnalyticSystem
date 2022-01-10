CREATE PROCEDURE [dbo].[GetAllPreferencesByCustomerId]
@Id integer
	as
	select * from dbo.[Preferences] as P
	where P.CustomerId = @Id
RETURN 0
