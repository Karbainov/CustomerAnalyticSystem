CREATE TABLE [dbo].[Product_Tag]
(
	[Id] integer identity primary key,
    [ProductId] integer NOT NULL,
    [TagId] integer
    Foreign key (ProductId) references [Product] (Id) NULL,
    Foreign key (TagId) references [Tag] (Id)
)
