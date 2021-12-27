CREATE TABLE [dbo].[Preferences]
(
	ID integer identity primary key,
	ProductID integer,
	CustumerID integer,
	TagID integer,
	GroupID integer,
	IsInterested bit,
	Foreign key (ProductID) references [Product] (ID),
	Foreign key (CustumerID) references [Customer] (ID),
	Foreign key (TagID) references [Tag] (ID),
	Foreign key (GroupID) references [Group] (ID)
)
