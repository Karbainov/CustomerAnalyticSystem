CREATE  procedure [dbo].[GetOrderModel]
as
select O.[Id], O.[Date], O.[CustomerId], S.[Name] as "Status", O.[Cost] from [dbo].[Order] as O
join [dbo].[Status] as S
	on S.Id = O.StatusId

