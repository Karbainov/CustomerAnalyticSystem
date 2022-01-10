CREATE TABLE [dbo].[Product]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY,
	[Name] nvarchar (35),
	[Description] nvarchar (100) NOT NULL,
	[GroupId] int NOT NULL,
	Foreign key ([GroupId]) references [Group]([Id])
)
