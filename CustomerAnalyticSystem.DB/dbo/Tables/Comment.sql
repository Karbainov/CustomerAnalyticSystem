CREATE TABLE [dbo].[Comment]
(
	[Id] integer identity primary key,
	[CustomerId] integer,
	[Text] nvarchar(255),
	Foreign key (CustomerId) references [Customer] (Id)
)
