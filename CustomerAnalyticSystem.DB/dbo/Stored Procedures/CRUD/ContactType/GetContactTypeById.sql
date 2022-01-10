CREATE PROCEDURE [dbo].[GetContactTypeById]
	@Id integer
as
select *
from dbo.[ContactType]
where Id = @Id
RETURN 0
