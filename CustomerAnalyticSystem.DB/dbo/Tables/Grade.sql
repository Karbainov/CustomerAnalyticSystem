CREATE TABLE [dbo].[Grade]
(
	[Id] integer identity primary key,
	ProductId integer NOT NULL,
	CustumerId integer NOT NULL,
	[Value] nvarchar (50) NOT NULL,
	Foreign key (ProductId) references [Product] (Id),
	Foreign key (CustumerId) references [Customer] (Id)
)
