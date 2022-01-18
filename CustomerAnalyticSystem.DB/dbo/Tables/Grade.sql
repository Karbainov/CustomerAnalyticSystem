CREATE TABLE [dbo].[Grade]
(
	[Id] integer identity primary key,
	[ProductId] integer NOT NULL,
	[CustumerId] integer NOT NULL,
	[Value] integer NOT NULL,
	Foreign key (ProductID) references [Product] (ID),
	Foreign key (CustumerID) references [Customer] (ID)
)
