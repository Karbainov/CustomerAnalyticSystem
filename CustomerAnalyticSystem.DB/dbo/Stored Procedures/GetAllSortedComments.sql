CREATE PROCEDURE [dbo].[GetAllSortedComments]
	as
select C.[Id], C.[CustomerId], C.[Text], C.[Id] as TempId
from [dbo].[Comment] as C
order by CustomerId
