CREATE TABLE [dbo].[Comment]
(
	[Id] integer identity primary key,
	[CustomerId] integer NOT NULL,
	[Text] nvarchar(255) NOT NULL,
	Foreign key (CustomerId) references [Customer] (Id)
)
