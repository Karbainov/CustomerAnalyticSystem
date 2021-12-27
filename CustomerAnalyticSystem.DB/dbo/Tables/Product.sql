CREATE TABLE [dbo].[Product]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY,
	[Name] nvarchar (35),
	[Description] nvarchar (100),
	[GroupId] int,
	Foreign key ([GroupId]) references [Group]([Id])
)
