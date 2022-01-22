﻿CREATE TABLE [dbo].[Order]
(
	Id integer identity primary key,
	CustomerId integer NOT NULL,
	Date NVARCHAR(10) NOT NULL,
	StatusId integer NOT NULL,
	[FirstName] nvarchar (50) NOT NULL,
	[LastName] nvarchar(50) NULL,Cost integer NOT NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
    Foreign key (StatusId) references [Status] (Id),
	Foreign key (CustomerId) references [Customer] (Id),

Foreign key (FirstName) references [Customer] (FirstName),
Foreign key (LastName) references [Customer] (LastName))
