CREATE PROCEDURE [dbo].[GetNumberOfTagsInOrderByCustomerId]
@Id integer
as
select PT.TagId, COUNT (O.Id) as 'Number' from [dbo].[Order] as O
join [dbo].[Check] as C
on O.Id = C.Id
join [dbo].[Product_Tag] as PT
on C.ProductId = PT.ProductId
where O.CustomerId = @Id
group by PT.TagId
Return @Id
