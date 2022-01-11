﻿CREATE TABLE [dbo].[Order]
(
	Id integer identity primary key,
	CustomerId integer NOT NULL,
	Date nvarchar(10) NOT NULL,
	StatusId integer NOT NULL,
	Cost integer NOT NULL,
	Foreign key (StatusID) references [Status] (Id),
	Foreign key (CustomerID) references [Customer] (ID)
)
