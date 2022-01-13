CREATE TABLE [dbo].[Customer]
(
	[Id] integer identity primary key,
	[FirstName] nvarchar(50) NULL,
	[LastName] nvarchar(50) NULL,
	[TypeId] integer NULL,
	Foreign key (TypeId) references [CustomerType] (Id)
)
