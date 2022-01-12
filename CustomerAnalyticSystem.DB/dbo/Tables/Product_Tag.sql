CREATE TABLE [dbo].[Product_Tag]
(
	[ID] integer identity primary key,
    [ProductId] integer NULL,
    [TagId] integer
    Foreign key (ProductId) references [Product] (Id) NULL,
    Foreign key (TagId) references [Tag] (Id)
)
