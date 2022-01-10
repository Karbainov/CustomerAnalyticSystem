CREATE TABLE [dbo].[Product_Tag]
(
	[ID] integer identity primary key,
    [ProductId] integer NOT NULL,
    [TagId] integer
    Foreign key (ProductId) references [Product] (Id) NOT NULL,
    Foreign key (TagId) references [Tag] (Id)
)
