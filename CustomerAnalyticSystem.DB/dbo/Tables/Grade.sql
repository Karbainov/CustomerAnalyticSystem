CREATE TABLE [dbo].[Grade]
(
	[ID] integer identity primary key,
	ProductID integer NULL,
	CustumerID integer NULL,
	[Value] nvarchar (50) NULL,
	Foreign key (ProductID) references [Product] (ID),
	Foreign key (CustumerID) references [Customer] (ID)
)
