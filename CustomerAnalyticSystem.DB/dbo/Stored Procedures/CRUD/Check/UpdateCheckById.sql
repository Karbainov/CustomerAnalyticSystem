CREATE PROCEDURE [dbo].[UpdateCheckById]
	@Id integer,
	@Amount integer,
	@Mark integer
as
	update [dbo].[Check]
	set Amount=@Amount,
	Mark=@Mark
	where Id=@Id
return @Id
