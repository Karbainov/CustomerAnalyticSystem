CREATE TABLE [dbo].[Grade]
(
	[Id] integer identity primary key,
	ProductId integer NOT NULL,
	CustumerId integer NOT NULL,
	[Value] nvarchar (30) NOT NULL,
	Foreign key (ProductId) references [Product] (Id),
	Foreign key (CustomerId) references [Customer] (Id)
)
