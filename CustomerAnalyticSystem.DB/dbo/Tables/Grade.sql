CREATE TABLE [dbo].[Grade]
(
	[ID] integer identity primary key,
	ProductID integer NOT NULL,
	CustumerID integer NOT NULL,
	[Value] nvarchar (50) NOT NULL,
	Foreign key (ProductID) references [Product] (ID),
	Foreign key (CustumerID) references [Customer] (ID)
)
