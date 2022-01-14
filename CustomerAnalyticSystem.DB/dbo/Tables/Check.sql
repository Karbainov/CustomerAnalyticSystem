CREATE TABLE [dbo].[Check]
(
	[Id] integer identity primary key,
	[ProductId] integer NULL,
	[OrderId] integer NULL,
	[Amount] integer NULL,
	[Mark] integer NULL,
	Foreign key (ProductId) references [Product] (Id),
	Foreign key (OrderId) references [Order] (Id)
)
