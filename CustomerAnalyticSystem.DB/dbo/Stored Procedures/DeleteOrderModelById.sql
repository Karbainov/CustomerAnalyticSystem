﻿CREATE PROCEDURE [dbo].[DeleteOrderModelById]
	@Id integer
AS
	update dbo.[Order]
	set IsDeleted = 1
	where Id= @Id
RETURN @Id
