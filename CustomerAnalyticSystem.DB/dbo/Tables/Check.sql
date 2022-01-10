CREATE TABLE [dbo].[Check]
(
	[Id] integer identity primary key,
	[ProductId] integer NOT NULL,
	[OrderId] integer NOT NULL,
	[Amount] integer NOT NULL,
	[Mark] integer,
	Foreign key (ProductId) references [Product] (Id),
	Foreign key (OrderId) references [Order] (Id)
)
