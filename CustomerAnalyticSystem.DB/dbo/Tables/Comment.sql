CREATE TABLE [dbo].[Comment]
(
	[Id] integer identity primary key,
	[CustomerId] integer NULL,
	[Text] nvarchar(255) NULL,
	Foreign key (CustomerId) references [Customer] (Id)
)
