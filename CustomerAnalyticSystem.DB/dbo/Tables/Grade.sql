CREATE TABLE [dbo].[Grade]
(
	[Id] integer identity primary key,
	[ProductId] integer NOT NULL,
	[CustomerId] integer NOT NULL,
	[Value] integer NULL,
	Foreign key (ProductID) references [Product] (ID),
	Foreign key (CustomerID) references [Customer] (ID)
)
