CREATE PROCEDURE [dbo].[DeleteContact]
@Id integer
as
delete
from dbo.[ContactType]
where Id = @Id
RETURN 0
