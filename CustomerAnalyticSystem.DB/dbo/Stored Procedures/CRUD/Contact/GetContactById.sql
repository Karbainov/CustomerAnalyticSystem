CREATE PROCEDURE [dbo].[GetContactById]
	@Id integer
as
select *
from dbo.[Contact]
where Id = @Id
RETURN 0
