CREATE TABLE [dbo].[Contact]
(
	[Id] integer identity primary key,
    [CustomerId] integer,
    Foreign key (CustomerId) references [Customer] (Id),
    [ContactTypeId] integer,
    Foreign key (ContactTypeId) references [ContactType] (Id),
    [Value] nvarchar(255)
)
