CREATE TABLE [dbo].[Contact]
(
	[Id] integer identity primary key,
    [CustomerId] integer NULL,
    Foreign key (CustomerId) references [Customer] (Id),
    [ContactTypeId] integer NULL,
    Foreign key (ContactTypeId) references [ContactType] (Id),
    [Value] nvarchar(255) NULL
)
