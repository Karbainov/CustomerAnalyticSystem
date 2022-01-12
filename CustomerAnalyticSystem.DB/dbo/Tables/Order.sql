CREATE TABLE [dbo].[Order]
(
	ID integer identity primary key,
	CustomerID integer NULL,
	Date nvarchar(10) NULL,
	StatusID integer NULL,
	Cost integer NULL,
	Foreign key (StatusID) references [Status] (Id),
	Foreign key (CustomerID) references [Customer] (ID)
)
