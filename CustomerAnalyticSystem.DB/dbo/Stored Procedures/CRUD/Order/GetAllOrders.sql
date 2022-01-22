﻿CREATE PROCEDURE [dbo].[GetAllOrders]
AS
	select O.Id, O.CustomerID,O.FirstName, O.LastName, O.Date, O.StatusID, O.Cost from dbo.[Order] as O
	where IsDeleted = 0
return 0
