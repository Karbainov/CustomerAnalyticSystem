CREATE TABLE [dbo].[Grade]
(
	[Id] integer identity primary key,
	ProductId integer NOT NULL,
	CustomerId integer NOT NULL,
	[Value] nvarchar (30) NULL,
	Foreign key (ProductId) references [Product] (Id),
	Foreign key (CustomerId) references [Customer] (Id)
)
