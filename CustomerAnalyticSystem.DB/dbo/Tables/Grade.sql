CREATE TABLE [dbo].[Grade]
(
	[ID] integer identity primary key,
	ProductID integer,
	CustumerID integer,
	[Value] nvarchar (50),
	Foreign key (ProductID) references [Product] (ID),
	Foreign key (CustumerID) references [Customer] (ID)
)
