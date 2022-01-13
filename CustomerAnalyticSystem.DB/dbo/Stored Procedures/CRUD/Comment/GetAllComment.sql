CREATE PROCEDURE [dbo].[GetAllComment]
	as
	select C.[Id], C.[CustomerId], C.[Text]
	from [dbo].[Comment] as C