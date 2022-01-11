CREATE TABLE [dbo].[Grade]
(
	[Id] integer identity primary key,
	ProductId integer NOT NULL,
	CustumerId integer NOT NULL,
	[Value] nvarchar (50) NOT NULL,
	Foreign key (ProductID) references [Product] (ID),
	Foreign key (CustumerID) references [Customer] (ID)
)
