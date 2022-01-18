CREATE TABLE [dbo].[Preferences]
(
	Id integer identity primary key,
	[ProductId] integer NULL,
	[CustomerId] integer NOT NULL,
	[TagId] integer NOT NULL,
	[GroupId] integer NOT NULL,
	[IsInterested] bit NOT NULL,
	Foreign key ([ProductId]) references [Product] (Id),
	Foreign key ([CustomerId]) references [Customer] (Id),
	Foreign key (TagId) references [Tag] (Id),
	Foreign key (GroupId) references [Group] (Id)
)
