CREATE TABLE [dbo].[Preferences]
(
	ID integer identity primary key,
	[ProductId] integer,
	[CustomerId] integer,
	TagID integer,
	GroupID integer,
	IsInterested bit,
	Foreign key ([ProductId]) references [Product] (ID),
	Foreign key ([CustomerId]) references [Customer] (ID),
	Foreign key (TagID) references [Tag] (ID),
	Foreign key (GroupID) references [Group] (ID)
)
