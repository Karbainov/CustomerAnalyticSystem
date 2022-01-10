CREATE TABLE [dbo].[Preferences]
(
	ID integer identity primary key,
	[ProductId] integer NOT NULL,
	[CustomerId] integer NOT NULL,
	TagID integer NOT NULL,
	GroupID integer NOT NULL,
	IsInterested bit NOT NULL,
	Foreign key ([ProductId]) references [Product] (ID),
	Foreign key ([CustomerId]) references [Customer] (ID),
	Foreign key (TagID) references [Tag] (ID),
	Foreign key (GroupID) references [Group] (ID)
)
