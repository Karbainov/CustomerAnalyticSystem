CREATE TABLE [dbo].[Customer]
(
	[Id] integer identity primary key,
	[FirstName] nvarchar(50),
	[LastName] nvarchar(50) NOT NULL,
	[TypeId] integer,
	Foreign key (TypeId) references [CustomerType] (Id)
)
