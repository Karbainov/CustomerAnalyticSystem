CREATE PROCEDURE [dbo].[DeleteCheckById]
	@Id integer
as
	delete [dbo].[Check]
	where Id=@Id
