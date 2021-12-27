CREATE TABLE [dbo].[Order]
(
	ID integer identity primary key,
	CustomerID integer,
	Date nvarchar(10),
	StatusID integer,
	Cost integer,
	Foreign key (StatusID) references [Status] (Id),
	Foreign key (CustomerID) references [Customer] (ID)
)
