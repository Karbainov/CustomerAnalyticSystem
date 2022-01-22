CREATE PROCEDURE [dbo].[GetAllCustomerWithContactAndContactType]
AS
	select C.Id, C.FirstName, C.LastName, CT.[Name], ConT.Id, ConT.[Name] as ContactTypeName, Con.[Value]  from [dbo].[Customer] as C
	join [dbo].[CustomerType] as CT
	on C.TypeId = CT.Id 
	join [dbo].[Contact] as Con
	on Con.CustomerId = C.Id 
	join [dbo].[ContactType] as ConT
	on ConT.Id = Con.ContactTypeId
	where C.IsDeleted = 0 and ConT.IsDeleted = 0 and Con.IsDeleted = 0 and CT.IsDeleted = 0
	order by C.Id
RETURN 0
