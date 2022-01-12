CREATE TABLE [dbo].[Preferences]
(
	ID integer identity primary key,
	[ProductId] integer NULL,
	[CustomerId] integer NULL,
	TagID integer NULL,
	GroupID integer NULL,
	IsInterested bit NULL,
	Foreign key ([ProductId]) references [Product] (ID),
	Foreign key ([CustomerId]) references [Customer] (ID),
	Foreign key (TagID) references [Tag] (ID),
	Foreign key (GroupID) references [Group] (ID)
)
