﻿CREATE PROCEDURE [dbo].[GetCustomerById]
	@Id integer
AS
	select C.Id, C.FirstName, C.LastName, C.TypeId, C.TypeId as 'TI' from [dbo].[Customer] as C
	where Id = @Id
return 0