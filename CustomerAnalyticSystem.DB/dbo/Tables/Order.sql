CREATE TABLE [dbo].[Order]
(
	ID integer identity primary key,
	CustomerID integer NOT NULL,
	Date nvarchar(10) NOT NULL,
	StatusID integer NOT NULL,
	Cost integer NOT NULL,
	Foreign key (StatusID) references [Status] (Id),
	Foreign key (CustomerID) references [Customer] (ID)
)
