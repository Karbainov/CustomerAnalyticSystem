CREATE TABLE [dbo].[Check]
(
	[Id] integer identity primary key,
	[ProductId] integer,
	[OrderId] integer,
	[Amount] integer,
	[Mark] integer,
	Foreign key (ProductId) references [Product] (Id),
	Foreign key (OrderId) references [Order] (Id)
)
