CREATE TABLE [dbo].[Product_Tag]
(
	[ID] integer identity primary key,
    [ProductId] integer,
    [TagId] integer
    Foreign key (ProductId) references [Product] (Id),
    Foreign key (TagId) references [Tag] (Id)
)
