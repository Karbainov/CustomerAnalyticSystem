CREATE TABLE [dbo].[Contact]
(
	[Id] integer identity primary key,
    [CustomerId] integer NOT NULL,
    Foreign key (CustomerId) references [Customer] (Id),
    [ContactTypeId] integer NOT NULL,
    Foreign key (ContactTypeId) references [ContactType] (Id),
    [Value] nvarchar(255) NOT NULL
)
